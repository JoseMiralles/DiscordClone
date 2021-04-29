using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Intalk.Models;

namespace Intalk.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }

        public virtual DbSet<Server> Server { get; set; }

        public virtual DbSet<UserServer> UserServers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Servers)
                .WithMany(s => s.Users)
                .UsingEntity<UserServer>(
                    j => j
                        .HasOne(us => us.Server)
                        .WithMany(s => s.UserServers)
                        .HasForeignKey(us => us.ServerId),
                    j => j
                        .HasOne(us => us.User)
                        .WithMany(u => u.UserServers)
                        .HasForeignKey(us => us.UserId)
                );
        }
    }
}