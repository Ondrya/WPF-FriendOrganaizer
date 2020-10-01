using FriendOrganaizer.Model;
using System.Collections.Generic;

namespace FriendOrganaizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            // TODO: load data from realdatabase
            yield return new Friend { FirstName = "FName1", LastName = "LName1" };
            yield return new Friend { FirstName = "FName2", LastName = "LName2" };
            yield return new Friend { FirstName = "FName3", LastName = "LName3" };
            yield return new Friend { FirstName = "FName4", LastName = "LName4" };
        }
    }
}
