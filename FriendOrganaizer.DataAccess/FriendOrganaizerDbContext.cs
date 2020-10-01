using FriendOrganaizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FriendOrganaizer.DataAccess
{
    public class FriendOrganaizerDbContext : DbContext
    {
        public FriendOrganaizerDbContext():base("FriendOrganaizerDb")
        {

        }
        public DbSet<Friend> Friends {get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
