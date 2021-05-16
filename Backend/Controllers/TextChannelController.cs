using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Data;
using Intalk.Models;
using Intalk.RealTime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Intalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/")]
    public class TextChannelController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private ITextChannelRepository _tcRepo;
        private IHubContext<InTalkHub> _hubContext;

        public TextChannelController (
            UserManager<ApplicationUser> userManager,
            ITextChannelRepository tcRepo,
            IHubContext<InTalkHub> hubContext
        )
        {
            _userManager = userManager;
            _tcRepo = tcRepo;
            _hubContext = hubContext;
        }

        [HttpGet("Server/{serverId}/TextChannels")]
        public async Task<ActionResult<IEnumerable<TextChannelResponse>>> Index(long serverId)
        {
            if (await _tcRepo.userIsOwner(_userManager.GetUserId(this.User), serverId))
            {
                return Ok(await _tcRepo.GetServerTextChannels(serverId));
            }
            return Unauthorized();
        }

        [HttpPost("TextChannels")]
        public async Task<ActionResult<TextChannelResponse>> POST([FromBody] CreateTextChannelRequest req)
        {
            string userId = _userManager.GetUserId(this.User);
            if (await _tcRepo.userIsOwner(userId, req.ServerId))
            {
                return Ok(_tcRepo.CreateChannel(req, userId));
            }
            return Unauthorized();
        }

        [HttpDelete("TextChannels/{id}")]
        public async Task<ActionResult<TextChannelResponse>> DELETE(long id)
        {
            string userId = _userManager.GetUserId(this.User);
            if (await _tcRepo.UserIsOwnerOfChannelServer(userId, id))
            {
                var channel = await _tcRepo.DeleteChannel(id);
                return Ok(channel);
            }
            return Unauthorized();
        }

        [HttpPatch("TextChannels/{id}")]
        public async Task<ActionResult<TextChannelResponse>> PATCH(long id, [FromBody] JsonPatchDocument<TextChannel> pathDoc)
        {
            string userId = _userManager.GetUserId(this.User);
            if (await _tcRepo.UserIsOwnerOfChannelServer(userId, id))
            {
                TextChannel tc = await _tcRepo.GetTextChannelById(id);
                if (tc == null) return NotFound();
                pathDoc.ApplyTo(tc);
                await _tcRepo.SaveChanges();
                return Ok(tc);
            }
            return Unauthorized();
        }
    }
}