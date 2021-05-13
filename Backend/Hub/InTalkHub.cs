using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using static Intalk.Models.UserServer;

namespace Intalk.RealTime
{
    [Authorize]
    public class InTalkHub : Hub
    {
        public override Task OnDisconnectedAsync(Exception exception)
        {
            // Remove user from servers, and notify them that the user went offline.
            string userId = this.Context.UserIdentifier;
            var serverIds = UserManager.RemoveUserFromAllGroupsAndGetServers(userId);
            NotifyServerMembers(serverIds, isOnline: false);
            return base.OnDisconnectedAsync(exception);
        }

        public void Connected(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Notifies all the members of all the servers in the list,
        /// that a user went online or offline.
        /// This method should be calles from the AuthController,
        /// when the user is authenticated.
        /// </summary>
        /// <param name="serverIds">Ids of servers that the user is a member of.</param>
        /// <param name="isOnline">Wether the user just went online or offline.</param>
        public void NotifyServerMembers(List<string> serverIds, bool isOnline)
        {
            string userId = this.Context.UserIdentifier;
            foreach (string group in serverIds){
                UserManager.userGroups.AddUserToGroup(userId, group);
                Clients.Groups(group).SendAsync("WentOnline", userId);
                Console.WriteLine("NOTIFIED: " + group);
            }
            if (isOnline) {
                Clients.Caller.SendAsync("messageReceived", "Hi!");
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