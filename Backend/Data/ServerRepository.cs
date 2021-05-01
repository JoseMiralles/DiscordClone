using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intalk.Data
{
    public class ServerRepository : IServerRepository, IDisposable
    {
        private ApiDbContext _context;
        private bool _disposed;

        private ApplicationUser _currentUser;

        public async Task<ApplicationUser> CurrentUser(string id)
        {
            if (_currentUser == null)
            {
                _currentUser = await _context.Users.OfType<ApplicationUser>()
                    .FirstAsync(u => u.Id == id);
            }
            return _currentUser;
        }

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
            (CreateServerRequest createServerRequest, string userId)
        {
            // Create server
            var server = new Server
            {
                Title = createServerRequest.Title
            };

            var user = await _context.Users.OfType<ApplicationUser>()
                .Include(u => u.Servers)
                .FirstAsync(u => u.Id == userId);

            user.Servers.Add(server);
            await _context.SaveChangesAsync();
            return server.Id;
        }

        public Task<long> DeleteServer(long serverId)
        {
            throw new NotImplementedException();
        }

        public async Task<SingleServerResponseItem> GetServerById(long serverId)
        {
            // TODO: Check is user is member of this server.
            Server server = await _context.Server.FindAsync(serverId);
            if (server == null) return null;
            return serverToSingleServerResponseItem(server);
        }

        public async Task<Server> GetCompleteServerById(long id)
        {
            return await _context.Server.FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MultipleServersResponseItem>> GetUserServers(string userId)
        {
            var User = await _context.Users.OfType<ApplicationUser>()
                .Include(u => u.Servers)
                .FirstOrDefaultAsync(u => u.Id == userId);
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

        /// <summary>
        /// Checks to see if the user with the given id, is a owner of the server with the given id.
        /// </summary>
        /// <returns>True if the user is an owner, false otherwise.</returns>
        public async Task<bool> userIsOwner(string userId, long serverId)
        {
            var userServer = await _context.UserServers
                .FirstOrDefaultAsync(us =>
                us.UserId == userId
                && us.ServerId == serverId
                // && us.Role == (int) UserServer.Roles.Owner
            );
            return userServer != null ? true : false;
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

    }
}