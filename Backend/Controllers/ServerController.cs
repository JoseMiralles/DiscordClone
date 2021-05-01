using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Intalk.Data;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Intalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private IServerRepository _serverRepo;

        public ServerController(
            UserManager<ApplicationUser> userManager,
            IServerRepository serverRepo
            )
        {
            _userManager = userManager;
            _serverRepo = serverRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MultipleServersResponseItem>>> Index()
        {
            // TODO: use user id instead of email.
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Ok(await _serverRepo.GetUserServers(userId));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SingleServerResponseItem>> GET(long id)
        {
            var serverResponseItem = await _serverRepo.GetServerById(id);
            if (serverResponseItem == null) return NotFound();
            return Ok(serverResponseItem);
        }

        [HttpPost]
        public async Task<ActionResult<SingleServerResponseItem>> POST(
            CreateServerRequest createServerRequest)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            long serverId = await _serverRepo.CreateServer(createServerRequest, userId);

            return CreatedAtAction(
                nameof(GET),
                new { id = serverId },
                serverId
            );
        }
    
        [HttpPatch("{id}")]
        public async Task<ActionResult<SingleServerResponseItem>> PATCH
            (long id, [FromBody] JsonPatchDocument<Server> pathDoc)
        {
            // Validate user ownership of server.
            string userId = _userManager.GetUserId(this.User);
            if (await _serverRepo.userIsOwner(userId: userId, serverId: id) == false)
                return Unauthorized();

            // Perform patch
            Server server = await _serverRepo.GetCompleteServerById(id);
            if (server == null) return NotFound();
            pathDoc.ApplyTo(server);
            await _serverRepo.SaveChanges();
            return Ok(server);
        }
    }
}