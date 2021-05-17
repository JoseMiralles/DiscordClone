using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;

namespace Intalk.Data
{
    public class MessageRepository : InTalkBaseRepository, IMessageRepositroy
    {
        public MessageRepository(ApiDbContext context) : base(context){}

        public Task<MessageResponse> CreateMessage(CreateMessageRequest req)
        {
            throw new System.NotImplementedException();
        }

        public Task<MessageResponse> DeleteMessage(long messageId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<MessageResponse>> GetChannelMessages(long channelId)
        {
            throw new System.NotImplementedException();
        }
    }
}