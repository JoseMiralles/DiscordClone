using System.ComponentModel.DataAnnotations;

namespace Intalk.Models.DTOs.Requests
{
    /// <summary>
    /// This is used to validate incoming requests to login a user.
    /// </summary>
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}