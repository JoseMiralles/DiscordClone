using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intalk.Data
{
    public class ServerRepository : IServerRepository, IDisposable
    {
        private ApiDbContext _context;
        private bool _disposed;

        public ServerRepository(ApiDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Creates and saves a new server, and adds the given user to it as an owner.
        /// </summary>
        /// <param name="createServerRequest"></param>
        /// <param name="userIdentifier">The identifier of the owner user</param>
        /// <returns>The Id of the new server</returns>
        public async Task<long> CreateServer
            (CreateServerRequest createServerRequest, string userIdentifier)
        {
            // Create server
            var server = new Server
            {
                Title = createServerRequest.Title
                // Users = new List<ApplicationUser>
                // {
                //     await _context.Users.OfType<ApplicationUser>()
                //         .FirstOrDefaultAsync(u => u.Email == userIdentifier)
                // }
            };

            var user = await _context.Users.OfType<ApplicationUser>()
                    .Include(u => u.Servers)
                    .FirstOrDefaultAsync(u => u.Email == userIdentifier);

            user.Servers.Add(server);

            // _context.Server.Add(server);
            await _context.SaveChangesAsync();
            return server.Id;
        }

        public Task DeleteServer(long serverId)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<SingleServerResponseItem> GetServerById(long serverId)
        {
            Server server = await _context.Server.FindAsync(serverId);
            if (server == null) return null;
            return serverToSingleServerResponseItem(server);
        }

        public async Task<ActionResult<IEnumerable<MultipleServersResponseItem>>> GetUserServers(string userId)
        {
            var User = await _context.Users.OfType<ApplicationUser>()
                .Include(u => u.Servers)
                .FirstOrDefaultAsync(u => u.Email == userId);
            Console.WriteLine(User);
            return await Task.FromResult(
                User.Servers.Select(
                    // Convert to MultipleServersResponseItem to avoid overposting.
                    x => ServerToMultipleServersResponseItem(x)
                ).ToList()
            );
        }

        private static MultipleServersResponseItem ServerToMultipleServersResponseItem
            (Server server)
        {
            return new MultipleServersResponseItem
            {
                Id = server.Id,
                Title = server.Title
            };
        }

        private static SingleServerResponseItem serverToSingleServerResponseItem
            (Server server)
        {
            return new SingleServerResponseItem
            {
                Id = server.Id,
                Title = server.Title
            };
        }
    }
}