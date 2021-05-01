using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using api_tests.DTOs;
using Intalk;
using Intalk.Controllers;
using Intalk.Data;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace api_tests
{
    public class ServerApiTests
        : IClassFixture<CustomWebApplicationFactory<Intalk.Startup>>
    {
        private readonly HttpClient _client;
        private readonly CustomWebApplicationFactory<Intalk.Startup> _factory;

        public ServerApiTests(
            CustomWebApplicationFactory<Intalk.Startup> factory
        )
        {
            this._factory = factory;
            _client = factory.CreateClient
                (new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false
                });
        }

        [Fact]
        public async Task CreateServer()
        {
            await LoginUser();

            Assert.Equal("test", "test");
        }

        /// <summary>
        /// Logs the user in, and updates JWT in _client.
        /// </summary>
        private async Task LoginUser()
        {
            var response = await _client.PostAsync(
                "/api/AuthManagment/Login",
                new StringContent(
                    "{\"email\": \"test@test.com\", \"Password\": \"!testPassword123456\"}",
                    Encoding.UTF8, "application/json")
            );
            string content = await response.Content.ReadAsStringAsync();
            var instance = JsonConvert.DeserializeObject<AuthResponse>(content);
            this._client.DefaultRequestHeaders.Authorization
                = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer", instance.Token
                );
            Console.WriteLine(_client.DefaultRequestHeaders.Authorization);
        }
    }
}
