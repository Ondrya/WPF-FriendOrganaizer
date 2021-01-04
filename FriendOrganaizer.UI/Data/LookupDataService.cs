using FriendOrganaizer.DataAccess;
using FriendOrganaizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganaizer.UI.Data
{
    public class LookupDataService : IFriendLookupDataService
    {
        private Func<FriendOrganaizerDbContext> _contextCreator;
        public LookupDataService(Func<FriendOrganaizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await 
                    ctx.Friends.AsNoTracking()
                    .Select(
                        f => new LookupItem()
                        {
                            Id = f.Id,
                            DisplayMember = f.LastName + " " + f.FirstName
                        })
                    .ToListAsync();
            }
        }

    }
}
