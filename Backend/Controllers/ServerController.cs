using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Intalk.Data;
using Intalk.Models;
using Intalk.Models.DTOs.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Intalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
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
        public async Task<IEnumerable<MultipleServersResponseItem>> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await _serverRepo.GetUserServers(userId);
        }
    }
}