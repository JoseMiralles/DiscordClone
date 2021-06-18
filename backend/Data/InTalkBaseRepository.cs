using System;
using System.Threading.Tasks;
using Intalk.Models;
using Microsoft.EntityFrameworkCore;

namespace Intalk.Data
{
    public abstract class InTalkBaseRepository : IIntalkBaseRepostory, IDisposable
    {
        private bool _disposed;

        protected ApiDbContext _context;

        protected InTalkBaseRepository(ApiDbContext context)
        {
            this._context = context;
        }

        public async Task<bool> userIsOwner(string userId, long serverId)
        {
            var userServer = await _context.UserServers
                .FirstOrDefaultAsync(us =>
                us.UserId == userId
                && us.ServerId == serverId
                && us.Role == (int)UserServer.Roles.Owner
            );
            return userServer != null ? true : false;
        }

        /// <summary>
        /// Checks to see if the user is either a member or a owner of the server.
        /// </summary>
        /// <returns>True if the user is part of the server.</returns>
        public async Task<bool> userIsMember(string userId, long serverId)
        {
            var userServer = await _context.UserServers
                .FirstOrDefaultAsync(us =>
                us.UserId == userId
                && us.ServerId == serverId
            );
            return userServer != null ? true : false;
        }

        public async Task<bool> UserIsOwnerOfChannelServer(string userId, long textChannelId)
        {
            var serverId = (await _context.TextChannels.FindAsync(textChannelId)).ServerId;
            return await this.userIsOwner(userId, serverId);
        }

        public async Task<object> UserIsMemberOfChannelServer(string userId, long textChannelId)
        {
            var serverId = (await _context.TextChannels.FindAsync(textChannelId)).ServerId;
            if (await this.userIsMember(userId, serverId)) return serverId;
            return null;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
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