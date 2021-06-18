using System.ComponentModel.DataAnnotations;

namespace Intalk.Models.DTOs.Requests
{
    public class UserRegistrationRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}