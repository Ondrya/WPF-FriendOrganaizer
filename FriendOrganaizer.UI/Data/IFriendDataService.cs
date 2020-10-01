using FriendOrganaizer.Model;
using System.Collections.Generic;

namespace FriendOrganaizer.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}