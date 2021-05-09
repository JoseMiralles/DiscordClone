using static Intalk.Models.UserServer;

namespace Intalk.Models.DTOs.Responses
{
    public class MultipleUserResponseItem
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public Roles Role { get; set; }
    }
}