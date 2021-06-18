using System.ComponentModel.DataAnnotations;

namespace Intalk.Models.DTOs.Requests
{
    /// <summary>
    /// This class is used to validate incoming requests for a new refresh token.
    /// </summary>
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}