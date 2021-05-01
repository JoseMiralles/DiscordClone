namespace api_tests.DTOs
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool Success { get; set; }
        public string[] Errors { get; set; }
    }
}