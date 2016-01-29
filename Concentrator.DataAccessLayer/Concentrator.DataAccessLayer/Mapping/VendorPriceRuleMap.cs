using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorPriceRuleMap : EntityTypeConfiguration<VendorPriceRule>
    {
        public VendorPriceRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorPriceRuleID);

            // Properties
            this.Property(t => t.Margin)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("VendorPriceRule");
            this.Property(t => t.VendorPriceRuleID).HasColumnName("VendorPriceRuleID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.VendorPriceCalculationID).HasColumnName("VendorPriceCalculationID");
            this.Property(t => t.Margin).HasColumnName("Margin");
            this.Property(t => t.UnitPriceIncrease).HasColumnName("UnitPriceIncrease");
            this.Property(t => t.CostPriceIncrease).HasColumnName("CostPriceIncrease");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.VendorPriceRuleIndex).HasColumnName("VendorPriceRuleIndex");
            this.Property(t => t.PriceRuleType).HasColumnName("PriceRuleType");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.VendorPriceRules)
                .HasForeignKey(d => d.BrandID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.VendorPriceRules)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.VendorPriceRules)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorPriceRules)
                .HasForeignKey(d => d.VendorID);
            this.HasOptional(t => t.VendorPriceCalculation)
                .WithMany(t => t.VendorPriceRules)
                .HasForeignKey(d => d.VendorPriceCalculationID);

        }
    }
}
