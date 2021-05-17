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
        private IHubContext<InTalkHub> this_hubContext;

        public MessagesController(
            UserManager<ApplicationUser> userManager,
            IMessageRepository messageRepo,
            IHubContext<InTalkHub> hubContext
        )
        {
            this._userManager = userManager;
            this._messageRepo = messageRepo;
            this_hubContext = hubContext;
        }

        [HttpGet("TextChannels/{textChannelId}/Messages")]
        public async Task<ActionResult<IEnumerable<MessageResponse>>> Index(long TextChannelId)
        {
            var userId = _userManager.GetUserId(this.User);
            if (await _messageRepo.UserIsMemberOfChannelServer(userId, TextChannelId))
            {
                return Ok(await _messageRepo.GetChannelMessages(TextChannelId));
            }
            return Unauthorized();
        }

        [HttpPost("Messages")]
        public async Task<ActionResult<MessageResponse>> POST(CreateMessageRequest req)
        {
            var userId = _userManager.GetUserId(this.User);
            if (await _messageRepo.UserIsMemberOfChannelServer(userId, req.TextChannelId))
            {
                return Ok(await _messageRepo.CreateMessage(req, userId));
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