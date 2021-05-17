using System.Threading.Tasks;

namespace Intalk.Data
{
    public interface IIntalkBaseRepostory
    {
        Task SaveChanges();
        Task<bool> userIsOwner(string userId, long serverId);
        Task<bool> userIsMember(string userId, long serverId);
        Task<bool> UserIsMemberOfChannelServer(string userId, long textChannelId);
        Task<bool> UserIsOwnerOfChannelServer(string userId, long textChannelId)
    }
}