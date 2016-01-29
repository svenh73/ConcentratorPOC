using System.Data.Entity.ModelConfiguration;
using CoolInvest.Entities;

namespace CoolInvest.DataAccessLayer
{
  public class CoolInvestProductMap : EntityTypeConfiguration<CoolInvestProduct>
  {
    public CoolInvestProductMap() : base()
    {
      this.Property(t => t.ExtraField).HasColumnName("ExtraField");
    }
  }
}
