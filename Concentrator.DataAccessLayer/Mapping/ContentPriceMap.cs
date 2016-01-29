using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentPriceMap : EntityTypeConfiguration<ContentPrice>
    {
        public ContentPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentPriceRuleID);

            // Properties
            this.Property(t => t.Margin)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ContentPriceLabel)
                .HasMaxLength(255);

            this.Property(t => t.AttributeValue)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ContentPrice");
            this.Property(t => t.ContentPriceRuleID).HasColumnName("ContentPriceRuleID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Margin).HasColumnName("Margin");
            this.Property(t => t.UnitPriceIncrease).HasColumnName("UnitPriceIncrease");
            this.Property(t => t.CostPriceIncrease).HasColumnName("CostPriceIncrease");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ContentPriceRuleIndex).HasColumnName("ContentPriceRuleIndex");
            this.Property(t => t.PriceRuleType).HasColumnName("PriceRuleType");
            this.Property(t => t.ContentPriceCalculationID).HasColumnName("ContentPriceCalculationID");
            this.Property(t => t.FixedPrice).HasColumnName("FixedPrice");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.BottomMargin).HasColumnName("BottomMargin");
            this.Property(t => t.ComparePricePosition).HasColumnName("ComparePricePosition");
            this.Property(t => t.MinComparePricePosition).HasColumnName("MinComparePricePosition");
            this.Property(t => t.MaxComparePricePosition).HasColumnName("MaxComparePricePosition");
            this.Property(t => t.SellMargin).HasColumnName("SellMargin");
            this.Property(t => t.ContentPriceLabel).HasColumnName("ContentPriceLabel");
            this.Property(t => t.CompareSourceID).HasColumnName("CompareSourceID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");

            // Relationships
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.AttributeID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductCompareSource)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.CompareSourceID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.VendorID);
            this.HasOptional(t => t.ContentPriceCalculation)
                .WithMany(t => t.ContentPrices)
                .HasForeignKey(d => d.ContentPriceCalculationID);

        }
    }
}
