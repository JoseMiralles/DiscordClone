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

        public override Task OnConnectedAsync()
        {
            List<string> joinedServerIds = new List<string>();
            string userId = this.Context.UserIdentifier;
            foreach (string serverId in joinedServerIds){
                UserManager.userGroups.AddUserToGroup(userId, serverId);
            }
            // TODO: send list of connected users to the client who just connected.
            Clients.Groups(joinedServerIds).SendAsync("IsOnline", userId, true);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            List<string> joinedServerIds = new List<string>();
            string userId = this.Context.UserIdentifier;
            foreach (string serverId in joinedServerIds){
                UserManager.userGroups.RemoveUserFromGroup(userId, serverId);
            }
            Clients.Groups(joinedServerIds).SendAsync("IsOnline", userId, false);
            return base.OnConnectedAsync();
        }

        /// <summary>
        /// Notifies server memebers that a user has changed roles.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="serverId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public Task ChangeRole(string userId, string serverId, Roles role)
        {
            return Clients.Group(serverId).SendAsync("Role", serverId, userId, role);
        }
    }

    static class UserManager
    {
        /// <summary>
        /// Keeps track of which users are online on each group (server).
        /// </summary>
        public static Dictionary<string, HashSet<string>> userGroups = new Dictionary<string, HashSet<string>>();

        /// <summary>
        /// Adds the given user to the given server list.
        /// It also creates a new server hash set if one didn't exist.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="serverId"></param>
        public static void AddUserToGroup
        (this Dictionary<string, HashSet<string>> self, string userId, string serverId)
        {
            if (!self.ContainsKey(serverId)) self.Add(serverId, new HashSet<string>());
            self[serverId].Add(userId);
        }

        /// <summary>
        /// Removes the given user id from the given server group.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="serverId"></param>
        public static void RemoveUserFromGroup
        (this Dictionary<string, HashSet<string>> self, string userId, string serverId)
        {
            self[serverId]?.Remove(userId);
        }
    }
}