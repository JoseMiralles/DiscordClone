using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;

namespace Intalk.Data
{
    public interface IServerRepository : IDisposable
    {
        Task<ICollection<MultipleServersResponseItem>> GetUserServers(string userId);
        Task<SingleServerResponseItem> GetServerById(string serverId);
        Task<SingleServerResponseItem> CreateServer(CreateServerRequest createServerRequest);
        Task DeleteServer(string serverId);
    }
}