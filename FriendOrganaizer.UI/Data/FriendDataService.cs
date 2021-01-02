using FriendOrganaizer.DataAccess;
using FriendOrganaizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrganaizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganaizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganaizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public IEnumerable<Friend> GetAll()
        {
            using (var ctx = _contextCreator())
            {
                return ctx.Friends.AsNoTracking().ToList();
            }
        }
    }
}
