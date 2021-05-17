using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;

namespace Intalk.Data
{
    public interface IMessageRepository : IIntalkBaseRepostory, IDisposable
    {
        Task<IEnumerable<MessageResponse>> GetChannelMessages(long channelId);
        Task<MessageResponse> CreateMessage(CreateMessageRequest req, string userId);
        Task<MessageResponse> DeleteMessage(long messageId);

        Task<bool> UserOwnsMessage(long messageId, string userId);
    }
}