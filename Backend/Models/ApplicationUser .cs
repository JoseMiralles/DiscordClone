using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Intalk.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Server> Servers { get; set; }
        public List<UserServer> UserServers { get; set; }
    }
}