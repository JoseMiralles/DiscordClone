using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intalk.Models
{
    public class Server
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
        public List<UserServer> UserServers { get; set; }

        public ICollection<TextChannel> TextChannels { get; set; }
    }

    /// <summary>
    /// Represents the user-server join table.
    /// </summary>
    public class UserServer
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public long ServerId { get; set; }
        public Server Server { get; set; }

        [Required]
        public int Role { get; set; }

        public enum Roles
        {
            Member = 0,
            Owner = 1
        }
    }
}