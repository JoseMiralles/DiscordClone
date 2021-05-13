using System.Collections.Generic;

namespace Intalk.RealTime
{
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
        public static HashSet<string> AddUserToGroup
        (this Dictionary<string, HashSet<string>> self, string userId, string serverId)
        {
            if (!self.ContainsKey(serverId)) self.Add(serverId, new HashSet<string>());
            self[serverId].Add(userId);
            return self[serverId];
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

        public static List<string> RemoveUserFromAllGroupsAndGetServers(string userId)
        {
            List<string> servers = new List<string>();
            foreach (var p in userGroups)
            {
                if (p.Value.Remove(userId)) servers.Add(p.Key);
            }
            return servers;
        }
    }
}