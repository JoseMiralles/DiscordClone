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
            // TODO: remove user from UserManager.
            string userId = this.Context.UserIdentifier;
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