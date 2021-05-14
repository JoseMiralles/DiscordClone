using static Intalk.Models.UserServer;

namespace Intalk.Models.DTOs.Responses
{
    public class MultipleUserResponseItem
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool online = false;
        public Roles Role { get; set; }
    }
}