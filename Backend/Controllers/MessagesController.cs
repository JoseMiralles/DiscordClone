using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Data;
using Intalk.Models;
using Intalk.RealTime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Intalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/")]
    public class MessagesController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private IMessageRepository _messageRepo;
        private IHubContext<InTalkHub> _hubContext;

        public MessagesController(
            UserManager<ApplicationUser> userManager,
            IMessageRepository messageRepo,
            IHubContext<InTalkHub> hubContext
        )
        {
            this._userManager = userManager;
            this._messageRepo = messageRepo;
            this._hubContext = hubContext;
        }

        [HttpGet("TextChannels/{textChannelId}/Messages/{offset}")]
        public async Task<ActionResult<IEnumerable<MessageResponse>>> Index(
            long TextChannelId,
            int offset = 0
        )
        {
            var userId = _userManager.GetUserId(this.User);
            var serverId = await _messageRepo.UserIsMemberOfChannelServer(userId, TextChannelId);
            if (serverId != null)
            {
                return Ok(await _messageRepo.GetChannelMessages(TextChannelId, offset));
            }
            return Unauthorized();
        }

        [HttpPost("Messages")]
        public async Task<ActionResult<MessageResponse>> POST(CreateMessageRequest req)
        {
            var userId = _userManager.GetUserId(this.User);
            var serverId = await _messageRepo.UserIsMemberOfChannelServer(userId, req.TextChannelId);
            if (serverId != null)
            {
                var message = await _messageRepo.CreateMessage(req, userId);
                await _hubContext.Clients.Group(serverId.ToString()).SendAsync("ReceiveMessage", message);
                return Ok(message);
            }
            return Unauthorized();
        }

        [HttpDelete("Messages/{id}")]
        public async Task<ActionResult<MessageResponse>> DELETE(long id)
        {
            var userId = _userManager.GetUserId(this.User);
            if (await _messageRepo.UserOwnsMessage(id, userId))
            {
                return Ok(await _messageRepo.DeleteMessage(id));
            }
            return Unauthorized();
        }
    }
}