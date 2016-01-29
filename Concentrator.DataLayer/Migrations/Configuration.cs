using Concentrator.Entities;

namespace Concentrator.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Configuration : DbMigrationsConfiguration<ConcentratorDataContext>
    {
        public Configuration()
        {
          AutomaticMigrationsEnabled = true;
        }

      // Initiele dataseed by creatie database
        protected override void Seed(ConcentratorDataContext context)
        {

          context.Configs.AddOrUpdate(x => x.Name,
            new Config { Name = "Test setting 1", Value = "1"},
            new Config { Name = "Test setting 2", Value = "2" },
            new Config { Name = "Test setting 3", Value = "3"}
          );
        }
    }
}
