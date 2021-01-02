using FriendOrganaizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}