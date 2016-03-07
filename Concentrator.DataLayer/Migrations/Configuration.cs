using System.Collections.Generic;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

  public class Configuration : DbMigrationsConfiguration<CNxtContext>
    {
        public Configuration()
        {
          AutomaticMigrationsEnabled = true;
        }

      // Initiele dataseed by creatie database
        protected override void Seed(CNxtContext context)
        {
          var settings = new List<Setting>();
          settings.Add(new Setting()
          {
            Name = "Test",
            DataType = "String"
          });
          
          //context.Settings.AddOrUpdate(p => p.Name, settings.ToArray());
        }
    }
}
