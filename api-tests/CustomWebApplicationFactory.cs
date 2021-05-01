using System;
using System.Linq;
using Intalk;
using Intalk.Data;
using Intalk.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace api_tests
{
    public class CustomWebApplicationFactory<TStartup>
        : WebApplicationFactory<Startup>
        where TStartup: class
    {

        private Intalk.Data.ApiDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private IServerRepository _serverRepository;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // This gets called after the original `ConfigureServices` method runs.
            builder.ConfigureServices(services =>
            {
                // Remove original database config.
                var descriptor = services.SingleOrDefault(d =>
                    d.ServiceType == typeof(DbContextOptions<Intalk.Data.ApiDbContext>));
                services.Remove(descriptor);

                // Set up temporary inMemory database.
                services.AddDbContext<Intalk.Data.ApiDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });

                var serviceProvicer = services.BuildServiceProvider();
                
                using (var scope = serviceProvicer.CreateScope())
                {
                    // Request services
                    var scopedServices = scope.ServiceProvider;
                    _context = scopedServices.GetRequiredService<Intalk.Data.ApiDbContext>();
                    var logger = scopedServices
                        .GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();
                    _context.Database.EnsureCreated();
                    _userManager = scopedServices.GetRequiredService<UserManager<ApplicationUser>>();
                    _serverRepository = scopedServices.GetRequiredService<IServerRepository>();
                    try
                    {
                        var utilites = new Utilities
                            (_context, _userManager, _serverRepository);
                        utilites.InitializeDbForTests();
                    }
                    catch(Exception ex)
                    {
                        logger.LogError(ex, "An error occurred seeding the " +
                            "database with test messages. Error: {Message}", ex.Message);
                    }
                }
            });
        }
    }
}