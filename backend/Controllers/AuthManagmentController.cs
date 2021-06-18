using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Intalk.Configuration;
using Intalk.Data;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Intalk.RealTime;
using Intalk.Util;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Intalk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagmentController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly ApiDbContext _apiDbContext;

        public AuthManagmentController(
            UserManager<ApplicationUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            TokenValidationParameters tokenValidationParameters,
            ApiDbContext apiDbContext)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            _tokenValidationParameters = tokenValidationParameters;
            _apiDbContext = apiDbContext;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest userRequest)
        {
            var response = new RegistrationResponse();
            if (this.ModelState.IsValid)
            {
                // Check if Email is already taken.
                var existingUser = await _userManager.FindByEmailAsync(userRequest.Email);
                if (existingUser != null)
                {
                    response.Errors["email"].Add("Email already in use");
                    response.Success = false;
                }

                // Check if Username is already taken.
                existingUser = await _userManager.FindByNameAsync(userRequest.Username);
                if (existingUser != null)
                {
                    response.Errors["username"].Add("Username already in use");
                    response.Success = false;
                }

                // One of the two previous validations failed.
                if (response.Errors["email"].Count > 0 || response.Errors["username"].Count > 0){
                    return BadRequest(response);
                }

                // Attempt to create a new user, and return tokens if successful.
                var newUser = new ApplicationUser()
                {
                    Email = userRequest.Email,
                    UserName = userRequest.Username
                };
                var createdUser = await _userManager.CreateAsync(newUser, userRequest.Password);

                // SUCCESS Return auth result
                if (createdUser != null && createdUser.Succeeded)
                {
                    AuthResult jwtToken = await GenerateJwtTokenAsync(newUser);
                    return Ok(jwtToken);
                }

                // The user creation failed, return a list of error descriptions.
                response.Errors["general"] = response.Errors["general"].Concat(
                    createdUser.Errors.Select(x => x.Description)
                    ).ToList();
                return BadRequest(response);
            }

            // Incoming payload did not match model.
            return ValidationFailed(response);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest userRequest)
        {
            var response = new RegistrationResponse();
            if (this.ModelState.IsValid)
            {
                // Check if there is a user with the given email.
                var existingUser = await _userManager.FindByEmailAsync(userRequest.Email);
                if (existingUser == null)
                {
                    response.Success = false;
                    response.Errors["general"].Add("Wrong Email or Password");
                    return BadRequest(response);
                }

                // Check if the password is correct.
                bool correctPassword = await _userManager.CheckPasswordAsync(existingUser, userRequest.Password);
                if (!correctPassword)
                {
                    response.Success = false;
                    response.Errors["general"].Add("Wrong Email or Password");
                    return BadRequest(response);
                }

                // Auth was successful, return tokens and OK response.
                AuthResult jwtToken = await GenerateJwtTokenAsync(existingUser);
                return Ok(jwtToken);
            }

            // Incoming payload did not match model.
            response.Success = false;
            response.Errors["general"].Add("Invalid payload");
            return BadRequest(response);
        }

        /// <summary>
        /// An endpoint that allows the client to request a new JWT to replace an expired one.
        /// This is assuming that the client has a valid refresh token.
        /// If not, then the user has to login again.
        /// </summary>
        /// <param name="tokenRequest">Should contain a refresh token</param>
        /// <returns></returns>
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest tokenRequest)
        {
            if (ModelState.IsValid)
            {
                AuthResult result = await VerifyAndGenerateToken(tokenRequest);
                if (result == null)
                {
                    return BadRequest(new AuthResult()
                    {
                        Errors = new List<string>(){
                            "Invalid token"
                        },
                        Success = false
                    });
                }

                if (result.Errors != null && result.Errors.Count > 0)
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }

            // Incoming payload did not match model.
            return BadRequest(new AuthResult()
            {
                Errors = new List<string>(){
                    "Invalid payload"
                },
                Success = false
            });
        }

        /// <summary>
        /// Merges the response errors with the errors from ModelState.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private ActionResult ValidationFailed(RegistrationResponse response)
        {   
            foreach(var field in ModelState){
                response.Errors[field.Key.ToCamelCase()].AddRange(
                    field.Value.Errors.Select(e => e.ErrorMessage).ToList());
            }

            return BadRequest(response);
        }

        private async Task<AuthResult> GenerateJwtTokenAsync(ApplicationUser existingUser)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(new []{
                    // new Claim("Id", existingUser.Id),
                    new Claim(JwtRegisteredClaimNames.NameId, existingUser.Id),
                    new Claim("username", existingUser.UserName),
                    // new Claim(JwtRegisteredClaimNames.Email, existingUser.Email),
                    // new Claim(JwtRegisteredClaimNames.Sub, existingUser.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);
            var refreshToken = new RefreshToken()
            {
                JwtId = token.Id,
                IsUsed = false,
                IsRevorked = false,
                UserId = existingUser.Id,
                AddedDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddMonths(6),
                Token = RandomString(35) + Guid.NewGuid()
            };

            await _apiDbContext.RefreshToken.AddAsync(refreshToken);
            await _apiDbContext.SaveChangesAsync();
            return new AuthResult()
            {
                Token = jwtToken,
                Success = true,
                RefreshToken = refreshToken.Token
            };
        }

        /// <summary>
        /// Performs multiple checks to ensure that a refresh token is valid, before returning a new JWT and refresh token.
        /// </summary>
        /// <param name="tokenRequest">The incoming request from the client</param>
        /// <returns>An AuthResult or null</returns>
        private async Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            try
            {
                // Validation 1 - Validation JWT token format
                _tokenValidationParameters.ValidateLifetime = false;
                var tokenInVerification = jwtTokenHandler.ValidateToken(tokenRequest.Token, _tokenValidationParameters, out var validatedToken);
                _tokenValidationParameters.ValidateLifetime = true;

                // Validation 2 - Validate encryption alg
                if(validatedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);

                    if(result == false) {
                        return null;
                    }
                }

                // Validation 3 - verify that the JWT is already expired.
                var utcExpiryDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

                DateTime expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

                if(expiryDate > DateTime.UtcNow) {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "UNEXPIRED_TOKEN: JWT has not yet expired"
                        }
                    };
                }

                // validation 4 - validate existence of the token
                var storedToken = await _apiDbContext.RefreshToken.FirstOrDefaultAsync(x => x.Token == tokenRequest.RefreshToken);

                if(storedToken == null)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token does not exist"
                        }
                    };
                }

                // Validation 5 - validate if used
                if(storedToken.IsUsed)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has been used"
                        }
                    };
                }

                // Validation 6 - validate if revoked
                if(storedToken.IsRevorked)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has been revoked"
                        }
                    };
                }

                // Validation 7 - validate the id
                var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

                if(storedToken.JwtId != jti)
                {
                    return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token doesn't match"
                        }
                    };
                }

                // update current token 

                storedToken.IsUsed = true;
                _apiDbContext.RefreshToken.Update(storedToken);
                await _apiDbContext.SaveChangesAsync();
                
                // Generate a new token
                var dbUser = await _userManager.FindByIdAsync(storedToken.UserId);
                return await GenerateJwtTokenAsync(dbUser);
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("Lifetime validation failed. The token is expired.")) {

                      return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Token has expired please re-login"
                        }
                    };
                
                } else {
                      return new AuthResult() {
                        Success = false,
                        Errors = new List<string>() {
                            "Something went wrong."
                        }
                    };
                }
            }    
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970, 1,1,0,0,0,0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();
            return dateTimeVal;
        }

        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length)
                .Select(x => x[random.Next(x.Length)]).ToArray()
            );
        }
    }
}