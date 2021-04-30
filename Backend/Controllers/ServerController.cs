using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Intalk.Data;
using Intalk.Models;
using Intalk.Models.DTOs.Requests;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await _serverRepo.GetUserServers(userId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SingleServerResponseItem>> GET(long id)
        {
            var serverResponseItem = await _serverRepo.GetServerById(id);
            if (serverResponseItem == null) return NotFound();
            return serverResponseItem;
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
    }
}