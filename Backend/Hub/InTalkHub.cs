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
            Console.WriteLine("CONNECTED: " + userId);
            var servers = await _serverRepo.GetUserServers(userId);

            string _tempServerId;
            HashSet<string> _tempServerUsers;
            HashSet<string> onlineUsersIds = new HashSet<string>();
            var serverList = new List<string>();
            foreach (var server in servers)
            {
                _tempServerId = server.Id.ToString();
                _tempServerUsers = UserManager.userGroups.AddUserToGroup(userId, _tempServerId);
                await this.Groups.AddToGroupAsync(Context.ConnectionId, _tempServerId);
                serverList.Add(_tempServerId);
                foreach (string _userId in _tempServerUsers) onlineUsersIds.Add(_userId);
            }

            await this.Clients.Groups(serverList).SendAsync("ReveiceUserStatus", userId, true);
            await this.Clients.Caller.SendAsync("ReceiveAllOnlineUsers", onlineUsersIds);
            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            // Remove user from servers, and notify them that the user went offline.
            string userId = this.Context.UserIdentifier;
            Console.WriteLine("DIS-CONNECTED: " + userId);
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