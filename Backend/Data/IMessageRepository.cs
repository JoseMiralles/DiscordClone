using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;

namespace Intalk.Data
{
    public interface IMessageRepositroy : IIntalkBaseRepostory, IDisposable
    {
        Task<IEnumerable<MessageResponse>> GetChannelMessages(long channelId);
        Task<MessageResponse> CreateMessage(CreateMessageRequest req);
        Task<MessageResponse> DeleteMessage(long messageId);
    }
}