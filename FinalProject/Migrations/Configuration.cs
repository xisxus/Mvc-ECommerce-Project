namespace FinalProject.Migrations
{
    using FinalProject.Models.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalProject.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalProject.Models.AppDbContext context)
        {
            ProjectSeedData.Seed(context);
        }
    }
}
