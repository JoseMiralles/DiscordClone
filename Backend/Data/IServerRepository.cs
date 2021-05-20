using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;

namespace Intalk.Data
{
    public interface IServerRepository : IIntalkBaseRepostory, IDisposable
    {
        Task<IEnumerable<MultipleServersResponseItem>> GetUserServers(string userId);
        Task<SingleServerResponseItem> GetServerById(long serverId);
        Task<IEnumerable<MultipleUserResponseItem>> GetServerUsers(long serverId);
        Task<SingleServerResponseItem> CreateServer(CreateServerRequest createServerRequest, string userIdentifier);
        Task<SingleServerResponseItem> DeleteServer(long serverId);
        Task<Server> GetCompleteServerById(long id);
    }
}