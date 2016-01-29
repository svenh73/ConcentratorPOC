using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderLineAppliedDiscountRuleMap : EntityTypeConfiguration<OrderLineAppliedDiscountRule>
    {
        public OrderLineAppliedDiscountRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.AppliedRuleID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OrderLineAppliedDiscountRule");
            this.Property(t => t.AppliedRuleID).HasColumnName("AppliedRuleID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.DiscountAmount).HasColumnName("DiscountAmount");
            this.Property(t => t.Percentage).HasColumnName("Percentage");
            this.Property(t => t.OrderLineID).HasColumnName("OrderLineID");
            this.Property(t => t.IsSet).HasColumnName("IsSet");

            // Relationships
            this.HasRequired(t => t.OrderLine)
                .WithMany(t => t.OrderLineAppliedDiscountRules)
                .HasForeignKey(d => d.OrderLineID);

        }
    }
}
