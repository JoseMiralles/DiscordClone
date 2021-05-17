using Intalk.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Intalk.Models.UserServer;

namespace Intalk.Data
{
    public static class Seed
    {
        public static void Run(ref ModelBuilder modelBuilder){

            // Seed demo users
            var users = new ApplicationUser[4];
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new ApplicationUser
                {
                    Id = $"migrationuserId{i}",
                    UserName = $"TestUser{i}",
                    NormalizedUserName = $"TESTUSER{i}",
                    Email = $"test{i}@test.com",
                    NormalizedEmail = $"TEST{i}@TEST.COM",
                };
                users[i].PasswordHash = passwordHasher.HashPassword(users[i], "Password123!");
            }
            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Seed servers
            var servers = new Server[4];
            for (int i = 0; i < servers.Length; i++)
            {
                servers[i] = new Server { Id = (-1 - i), Title = $"Server#{i}" };
            }
            modelBuilder.Entity<Server>().HasData(servers);

            // Seed user-server relationship
            var userServers = new UserServer[users.Length * servers.Length];
            int idx = 0;
            for (int i = 0; i < servers.Length; i++)
            {
                for (int x = 0; x < users.Length; x++)
                {
                    userServers[idx] = new UserServer {
                        Id = (-1 - idx),
                        ServerId = servers[i].Id,
                        UserId = users[x].Id,
                        Role = (i == x) ? (int) Roles.Owner : (int) Roles.Member
                    };
                    idx++;
                }
            }
            modelBuilder.Entity<UserServer>().HasData(userServers);

            int channelsPerServer = 4;
            var textChannels = new TextChannel[servers.Length * channelsPerServer];
            idx = 0;
            foreach (Server server in servers)
            {
                for (int i = 1; i <= channelsPerServer; i++)
                {
                    textChannels[idx] = new TextChannel
                    {
                        Id = (-1 - idx),
                        Title = "Text Channel #" + idx.ToString(),
                        ServerId = server.Id
                    };
                    idx++;
                }
            }
            modelBuilder.Entity<TextChannel>().HasData(textChannels);

            int messagesPerChannel = 40;
            var messages = new Message [textChannels.Length * messagesPerChannel];
            idx = 0;
            foreach(var channel in textChannels)
            {
                for (int i = 1; i <= messagesPerChannel; i++)
                {
                    messages[idx] = new Message
                    {
                        Id = (-1 - idx),
                        Text = "This is message number " + idx.ToString(),
                        UserId = users[(idx % (users.Length - 1))].Id,
                        TextChannelId = textChannels[idx % (textChannels.Length - 1)].Id
                    };
                    idx++;
                }
            }
            modelBuilder.Entity<Message>().HasData(messages);
        }
    }
}