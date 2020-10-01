namespace FriendOrganaizer.DataAccess.Migrations
{
    using FriendOrganaizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganaizer.DataAccess.FriendOrganaizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganaizer.DataAccess.FriendOrganaizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend() { FirstName = "Julia", LastName = "Egorova" },
                new Friend() { FirstName = "Liza", LastName = "Evsugina" },
                new Friend() { FirstName = "Marina Ivanovna", LastName = "" },
                new Friend() { FirstName = "Vasilij Aleksandrovich", LastName = "" }
                );
        }
    }
}
