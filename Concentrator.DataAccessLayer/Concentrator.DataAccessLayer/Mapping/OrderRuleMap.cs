using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderRuleMap : EntityTypeConfiguration<OrderRule>
    {
        public OrderRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.RuleID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("OrderRule");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Score).HasColumnName("Score");
        }
    }
}
