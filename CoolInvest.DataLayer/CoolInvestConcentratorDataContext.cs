using System.Data.Entity;
using Concentrator.Entities;
using CoolInvest.Entities;

namespace CoolInvest.DataAccessLayer
{
  public class CoolInvestDataContext : CNxtContext
  {
    public new DbSet<CoolInvestProduct> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.Add(new CoolInvestProductMap());
    }
  }
}
