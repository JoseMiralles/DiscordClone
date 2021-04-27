using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Intalk.Models;

namespace Intalk.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}