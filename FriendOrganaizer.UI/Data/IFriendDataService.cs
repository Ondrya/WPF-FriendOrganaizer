using FriendOrganaizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
        Task SaveAsync(Friend friend);
    }
}