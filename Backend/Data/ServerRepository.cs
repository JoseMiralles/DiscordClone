using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
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

        public Task<SingleServerResponseItem> CreateServer(CreateServerRequest createServerRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServer(string serverId)
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

        public Task<SingleServerResponseItem> GetServerById(string serverId)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<MultipleServersResponseItem>> GetUserServers(string userId)
        {
            var User = await _context.Users.OfType<ApplicationUser>()
                .Include(u => u.Servers)
                .FirstOrDefaultAsync(u => u.Id == userId);
            Console.WriteLine(User);
            return (ICollection<MultipleServersResponseItem>) User?.Servers;
        }
    }
}