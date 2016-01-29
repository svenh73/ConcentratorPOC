using System.Data.Entity;
using Concentrator.DataLayer;
using CoolInvest.Entities;

namespace CoolInvest.DataAccessLayer
{
  public class CoolInvestDataContext : ConcentratorDataContext
  {
    public new DbSet<CoolInvestProduct> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.Add(new CoolInvestProductMap());
    }
  }
}
