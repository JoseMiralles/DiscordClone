using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Intalk.Data
{
    public interface IServerRepository : IDisposable
    {
        Task<ActionResult<IEnumerable<MultipleServersResponseItem>>> GetUserServers(string userId);
        Task<SingleServerResponseItem> GetServerById(long serverId);
        Task<long> CreateServer(CreateServerRequest createServerRequest, string userIdentifier);
        Task<long> DeleteServer(long serverId);

        Task<SingleServerResponseItem> PatchServer(long id, )
    }
}