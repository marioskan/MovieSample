namespace MovieSample.identityMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration2 : DbMigrationsConfiguration<MovieSample.Models.ApplicationDbContext>
    {
        public Configuration2()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"identityMigrations";
        }

        protected override void Seed(MovieSample.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
