using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using api_tests.DTOs;
using Intalk;
using Intalk.Controllers;
using Intalk.Data;
using Intalk.Models;
using Microsoft.Extensions.DependencyInjection;
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
            _factory = factory;
            _client = factory.CreateClient
                (new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false
                });
        }

        [Fact]
        public async Task CreateAndGetServer()
        {
            await LoginUser();
            string newServerTitle = "new server title";

            // Create server
            var response = await _client.PostAsync(
                "/api/Server",
                new StringContent(
                    "{\"title\":\"" + newServerTitle + "\"}",
                    Encoding.UTF8, "application/json")
            );
            var content = await response.Content.ReadAsStringAsync();
            var serverId = JsonConvert.DeserializeObject<long>(content);

            // Check if returned server id is bigger than 0.
            Assert.InRange(serverId, 1, long.MaxValue);

            // Get server
            response = await _client.GetAsync(
                "/api/Server/" + serverId);
            content = await response.Content.ReadAsStringAsync();
            var server = JsonConvert.DeserializeObject
                <Intalk.Models.DTOs.Responses.SingleServerResponseItem>
                (content);
            
            // Check if returned title is the same as the one created.
            Assert.Equal(server.Title, newServerTitle);
        }

        /// <summary>
        /// Gets the servers for the logged in user, and asserts that there are at least
        /// two servers, and that the title of 2 of the servers are correct.
        /// </summary>
        [Fact]
        public async Task GetUserServers()
        {
            await LoginUser();
            var response = await _client.GetAsync(
                "/api/Server/");
            var stringContent = await response.Content.ReadAsStringAsync();
            var servers = JsonConvert.DeserializeObject
                <List<Intalk.Models.DTOs.Responses.MultipleServersResponseItem>>
                (stringContent);

            // Assert that there are at least 2 servers in the list.
            Assert.InRange(servers.Count, 2, int.MaxValue);

            // Assert that the titles are correct.
            Assert.Contains("Server title", servers[0].Title);
            Assert.Contains("Server title", servers[2].Title);
        }

        [Fact]
        public async Task PatchServer()
        {
            await LoginUser();

            int serverId = 2;
            string newTitle = "new server title";
            var response = await _client.PatchAsync
            ("api/Server/" + serverId,
            new StringContent(
                @"[
                    {
                        ""op"": ""replace"",
                        ""path"": ""/title"",
                        ""value"":" + "\"" + newTitle + "\"" + @",
                    }
                ]",
                Encoding.UTF8, "application/json"
            ));

            var stringContent = await response.Content.ReadAsStringAsync();
            var responseServer = JsonConvert.DeserializeObject
                <Intalk.Models.DTOs.Responses.SingleServerResponseItem>
                (stringContent);
            // Asssert that the title from the patch response is the new title.
            Assert.Equal(responseServer.Title, newTitle);

            var server = await GetServer(serverId);
            // Assert that the title of the server from the get request is the new title.
            Assert.Equal(server.Title, newTitle);
        }

        private async Task<Intalk.Models.DTOs.Responses.SingleServerResponseItem>
            GetServer(long serverId)
        {
            var response = await _client.GetAsync(
                "/api/Server/" + serverId);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject
                <Intalk.Models.DTOs.Responses.SingleServerResponseItem>
                (content);
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
            // Console.WriteLine(_client.DefaultRequestHeaders.Authorization);
        }
    }
}
