using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Intalk.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using static Intalk.Models.UserServer;

namespace Intalk.RealTime
{
    [Authorize]
    public class InTalkHub : Hub
    {

        private IServerRepository _serverRepo;

        public InTalkHub (IServerRepository serverRepo)
        {
            _serverRepo = serverRepo;
        }

        public override async Task OnConnectedAsync()
        {
            string userId = this.Context.UserIdentifier;
            var servers = await _serverRepo.GetUserServers(userId);
            string _tempServerID;
            foreach (var server in servers)
            {
                _tempServerID = server.Id.ToString();
                UserManager.userGroups.AddUserToGroup(userId, _tempServerID);
                await this.Clients.Groups(_tempServerID)
                    .SendAsync("ReveiceUserStatus", userId, true);
            }
            await base.OnConnectedAsync();
        }

        /// <summary>
        /// Sender gets a list of all of the users that are online on newServer, and also
        /// subscribes to listen for user status changes for this one server.
        /// It unsubscribes from the oldServer.
        /// </summary>
        /// <param name="newServer"></param>
        /// <param name="oldServer"></param>
        public async Task SelectServer(string newServer, string oldServer = null)
        {
            // TODO: Check if user is part of server.
            string userId = this.Context.UserIdentifier;
            if (oldServer != null) await this.Groups.RemoveFromGroupAsync(
                this.Context.ConnectionId, oldServer);
            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, newServer);
            var onlineUsers = UserManager.GetOnlineUsersFromServers(newServer);
            await this.Clients.Caller.SendAsync(
                "ReceiveAllOnlineUsers",
                onlineUsers != null ? onlineUsers : Array.Empty<string>());
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            // Remove user from servers, and notify them that the user went offline.
            string userId = this.Context.UserIdentifier;
            var serverIds = UserManager.RemoveUserFromAllGroupsAndGetServers(userId);
            NotifyServerMembers(serverIds, isOnline: false);

            return base.OnDisconnectedAsync(exception);
        }

        /// <summary>
        /// Notifies all the members of all the servers in the list,
        /// that a user went online or offline.
        /// This method should be calles from the AuthController,
        /// when the user is authenticated.
        /// </summary>
        /// <param name="serverIds">Ids of servers that the user is a member of.</param>
        /// <param name="isOnline">Wether the user just went online or offline.</param>
        private void NotifyServerMembers(List<string> serverIds, bool isOnline)
        {
            string userId = this.Context.UserIdentifier;
            foreach (string group in serverIds){
                UserManager.userGroups.AddUserToGroup(userId, group);
                Clients.Group(group).SendAsync("ReveiceUserStatus", userId, isOnline);
            }
        } 

        /// <summary>
        /// Notifies server memebers that a user has changed roles.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="serverId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public Task ChangeRole(string serverId, Roles role)
        {
            string userId = this.Context.UserIdentifier;
            return Clients.Group(serverId).SendAsync("Role", serverId, userId, role);
        }
    }
}