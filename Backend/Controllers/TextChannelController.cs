using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Intalk.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/")]
    public class TextChannelController
    {
        [HttpGet("Server/{id}/TextChannels")]
        public async Task<IEnumerable<TextChannelResponse>> Index(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost("/TextChannels")]
        public async Task<TextChannelResponse> POST([FromBody] CreateTextChannelRequest req)
        {
            var channel = new TextChannel
            {
                Title = req.Title,
                ServerId = req.ServerId
            };

            throw new NotImplementedException();
        }

        [HttpDelete("/TextChannels/{id}")]
        public async Task<TextChannelResponse> DELETE(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("{/TextChannels/id}")]
        public async Task<TextChannelResponse> PATCH(long id, [FromBody] JsonPatchDocument<TextChannel> pathDoc)
        {
            throw new NotImplementedException();
        }
    }
}