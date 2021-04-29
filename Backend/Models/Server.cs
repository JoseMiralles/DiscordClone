using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intalk.Models
{
    public class Server
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
        public List<UserServer> UserServers { get; set; }
    }

    public class UserServer
    {
        [Key]
        public string Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public Server Server { get; set; }
        public string ServerId { get; set; }

        public int Role { get; set; }

        public enum Roles
        {
            Member = 0,
            Owner = 1
        }
    }
}