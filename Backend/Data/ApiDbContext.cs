using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Intalk.Models;
using Microsoft.AspNetCore.Identity;

namespace Intalk.Data
{
    public class ApiDbContext : IdentityDbContext<ApplicationUser>
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

            // Define UserServer custom relationship.
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(users => users.Servers)    // ApplicationUser has many Servers
                .WithMany(servers => servers.Users) // These servers have many ApplicationUsers
                .UsingEntity<UserServer>(
                    US => US
                        .HasOne(userServer => userServer.Server)
                        .WithMany(server => server.UserServers)
                        .HasForeignKey(userServer => userServer.ServerId),
                    US => US
                        .HasOne(userServer => userServer.User)
                        .WithMany(user => user.UserServers)
                        .HasForeignKey(userServer => userServer.UserId)
                );

            // Seed data usin custom seeder.
            Seed.Run(ref modelBuilder);
        }
    }
}