using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;

namespace Intalk.Data
{
    public interface ITextChannelRepository
    {
        Task<IEnumerable<TextChannelResponse>> GetServerTextChannels(long serverId);
        Task<TextChannelResponse> CreateChannel(CreateTextChannelRequest req, string userId);
        Task<TextChannelResponse> DeleteChannel(long id);
    }
}