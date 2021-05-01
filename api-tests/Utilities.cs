using System;
using System.Linq;
using Intalk.Data;
using Intalk.Models;
using Microsoft.AspNetCore.Identity;

namespace api_tests
{
    internal class Utilities
    {
        private ApiDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private IServerRepository _serverRepository;

        public Utilities(
            ApiDbContext context,
            UserManager<ApplicationUser> userManager,
            IServerRepository serverRepository)
        {
            this._context = context;
            this._userManager = userManager;
            this._serverRepository = serverRepository;
        }

        internal void InitializeDbForTests()
        {
            this.GenerateUsers();
            this.GenerateServers();
            _context.SaveChanges();
        }

        /// <summary>
        /// Generates multiple servers for testing purposes.
        /// </summary>
        private void GenerateServers()
        {
            var request = new Intalk.Models.DTOs.Requests.CreateServerRequest();
            var user = _context.Users.First();
            for (int i = 0; i <= 4; i++)
            {
                request.Title = "Server title " + i;
                _serverRepository.CreateServer(request, user.Id);
            }
        }

        private void GenerateUsers()
        {
            var newUser = new ApplicationUser()
            {
                Email = "test@test.com",
                UserName = "testUser"
            };
            var createdUser = _userManager.CreateAsync(newUser, "!testPassword123456");
            newUser = new ApplicationUser()
            {
                Email = "test2@test2.com",
                UserName = "testUser2"
            };
            createdUser = _userManager.CreateAsync(newUser, "!testPassword123456");
        }
    }
}