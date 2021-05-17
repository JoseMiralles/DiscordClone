using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Models;
using Microsoft.EntityFrameworkCore;

namespace Intalk.Data
{
    public class MessageRepository : InTalkBaseRepository, IMessageRepository
    {
        public MessageRepository(ApiDbContext context) : base(context){}

        public async Task<MessageResponse> CreateMessage(CreateMessageRequest req, string userId)
        {
            var newMessage = new Message
            {
                Text = req.Text,
                UserId = userId,
                TextChannelId = req.TextChannelId
            };
            _context.Messages.Add(newMessage);
            await SaveChanges();
            return MessageToMessageResponse(newMessage);
        }

        public async Task<MessageResponse> DeleteMessage(long messageId)
        {
            var message = await _context.Messages.FindAsync(messageId);
            if (message != null){
                _context.Remove(message);
                await SaveChanges();
                return MessageToMessageResponse(message);
            }
            return null;
        }

        public async Task<IEnumerable<MessageResponse>> GetChannelMessages(long channelId)
        {
            var messages = await _context.Messages
                .Where(m => m.TextChannelId == channelId)
                .Select(m => MessageToMessageResponse(m))
                .ToListAsync();
            return messages;
        }

        public static MessageResponse MessageToMessageResponse(Message message)
        {
            return new MessageResponse
            {
                Id = message.Id,
                Text = message.Text,
                TextChannelId = message.TextChannelId,
                UserId = message.UserId
            };
        }

        public async Task<bool> UserOwnsMessage(long messageId, string userId)
        {
            return (await _context.Messages.FindAsync(messageId)).UserId == userId;
        }
    }
}