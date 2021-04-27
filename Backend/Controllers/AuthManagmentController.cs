using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Configuration;
using Intalk.Data;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TodoApp.Models.DTOs.Requests;

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
            JwtConfig jwtConfig,
            TokenValidationParameters tokenValidationParameters,
            ApiDbContext apiDbContext)
        {
            _userManager = userManager;
            _jwtConfig = jwtConfig;
            _tokenValidationParameters = tokenValidationParameters;
            _apiDbContext = apiDbContext;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest userRequest)
        {
            if (this.ModelState.IsValid)
            {
                // Check if someone is already using this email.
                var existingUser = await _userManager.FindByEmailAsync(userRequest.Email);
                if (existingUser != null)
                {
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>() {
                            "Email already in use"
                        }
                    });
                }

                // Attempt to create a new user, and return tokens if successful.
                var newUser = new ApplicationUser()
                {
                    Email = userRequest.Email,
                    UserName = userRequest.Username
                };
                var createdUser = await _userManager.CreateAsync(newUser, userRequest.Password);
                if (createdUser.Succeeded)
                {
                    AuthResult jwtToken = await GenerateJwtToken(newUser);
                    return Ok(jwtToken);
                }
                
                // The user creation failed, return a list of error descriptions.
                return BadRequest(new RegistrationResponse(){
                    Errors = createdUser.Errors.Select(x => x.Description).ToList(),
                    Success = false
                });
            }

            // Incoming payload did not match model.
            return BadRequest(new RegistrationResponse() {
                Errors = new List<string>(){
                    "Invalid payload"
                },
                Success = false
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest userRequest)
        {
            if (this.ModelState.IsValid)
            {
                // Check if there is a user with the given email.
                var existingUser = await _userManager.FindByEmailAsync(userRequest.Email);
                if (existingUser == null)
                {
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>(){
                            "Invalid login request"
                        },
                        Success = false
                    });
                }

                // Check if the password is correct.
                bool correctPassword = await _userManager.CheckPasswordAsync(existingUser, userRequest.Password);
                if (!correctPassword)
                {
                    return BadRequest(new RegistrationResponse(){
                        Errors = new List<string>() {
                            "Invalid login request"
                        },
                        Success = false
                    });
                }

                // Auth was successful, return tokens and OK response.
                AuthResult jwtToken = await GenerateJwtToken(existingUser);
                return Ok(jwtToken);
            }

            // Incoming payload did not match model.
            return BadRequest(new RegistrationResponse(){
                Errors = new List<string>(){
                    "Invalid payload"
                },
                Success = false
            });
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
                    return BadRequest(new RegistrationResponse()
                    {
                        Errors = new List<string>(){
                            "Invalid token"
                        },
                        Success = false
                    });
                }

                return Ok(result);
            }

            // Incoming payload did not match model.
            return BadRequest(new RegistrationResponse()
            {
                Errors = new List<string>(){
                    "Invalid payload"
                },
                Success = false
            });
        }

        /// <summary>
        /// Performs multiple checks to ensure that a refresh token is valid, before returning a new JWT and refresh token.
        /// </summary>
        /// <param name="tokenRequest">The incoming request from the client</param>
        /// <returns>An AuthResult or null</returns>
        private Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            throw new NotImplementedException();
        }

        private Task<AuthResult> GenerateJwtToken(ApplicationUser existingUser)
        {
            throw new NotImplementedException();
        }
    }
}