using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;

namespace Intalk.Data
{
    public interface ITextChannelRepository : IIntalkBaseRepostory
    {
        Task<IEnumerable<TextChannelResponse>> GetServerTextChannels(long serverId);
        Task<TextChannelResponse> CreateChannel(CreateTextChannelRequest req, string userId);
        Task<TextChannelResponse> DeleteChannel(long id);
        
        /// <summary>
        /// Checks to see if the user is an owner of the server to which this channel belongs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        Task<bool> UserIsOwnerOfChannelServer(string userId, long id);
        Task<TextChannel> GetTextChannelById(long id);
    }
}