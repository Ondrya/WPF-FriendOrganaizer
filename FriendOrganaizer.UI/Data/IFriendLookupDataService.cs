using FriendOrganaizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.Data
{
    public interface IFriendLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetFriendLookupAsync();
    }
}