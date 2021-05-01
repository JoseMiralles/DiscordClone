using System;
using Intalk.Data;
using Intalk.Models;
using Microsoft.AspNetCore.Identity;

namespace api_tests
{
    internal class Utilities
    {
        private ApiDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public Utilities(ApiDbContext context, UserManager<ApplicationUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }

        internal void InitializeDbForTests()
        {
            this.GenerateUsers();
            _context.SaveChanges();
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