using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intalk.Models;
using Microsoft.EntityFrameworkCore;

namespace Intalk.Data
{
    public class TextChannelRepository : InTalkBaseRepository, ITextChannelRepository
    {
        public TextChannelRepository(ApiDbContext context) : base(context){}

        public async Task<TextChannelResponse> CreateChannel(CreateTextChannelRequest req, string userId)
        {
            var channel = new TextChannel
            {
                Title = req.Title,
                ServerId = req.ServerId
            };

            var server = await _context.Server.FindAsync(req.ServerId);
            server.TextChannels.Add(channel);
            await _context.SaveChangesAsync();
            return ChannelToChannelResponse(channel);
        }

        public async Task<TextChannelResponse> DeleteChannel(long id)
        {
            var channel = await _context.TextChannels.FindAsync(id);
            if (channel == null) return null;
            var deletedChannel = _context.TextChannels.Remove(channel);
            await _context.SaveChangesAsync();
            return ChannelToChannelResponse(channel);
        }

        public async Task<IEnumerable<TextChannelResponse>> GetServerTextChannels(long serverId)
        {
            return await _context.TextChannels.Where(tc => tc.ServerId == serverId)
                .Select(tc => ChannelToChannelResponse(tc))
                .ToListAsync();
        }

        private TextChannelResponse ChannelToChannelResponse(TextChannel channel)
        {
            return new TextChannelResponse {
                Id = channel.Id,
                Title = channel.Title,
                ServerId = channel.ServerId
            };
        }
    }
}