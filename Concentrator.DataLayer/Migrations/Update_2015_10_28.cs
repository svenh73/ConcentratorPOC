using System;
using System.Data.Entity.Migrations;

namespace Concentrator.DataLayer
{

  public partial class Update_2015_10_28 : DbMigration
  {
    public override void Up()
    {

      AddColumn("dbo.Setting", "Test4", c => c.String());

      Sql("update config set name='b' where name='a';");
    }

    public override void Down()
    {
      DropColumn("dbo.Config", "Test4");

      Sql("update config set name='a' where name='b';");
    }
  }
}
