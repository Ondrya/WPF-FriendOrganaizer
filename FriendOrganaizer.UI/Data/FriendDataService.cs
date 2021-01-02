using FriendOrganaizer.DataAccess;
using FriendOrganaizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganaizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganaizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Friend>> GetAllAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
