using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompareMap : EntityTypeConfiguration<ProductCompare>
    {
        public ProductCompareMap()
        {
            // Primary Key
            this.HasKey(t => t.CompareProductID);

            // Properties
            this.Property(t => t.ConnectorCustomItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.VendorItemNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCompare");
            this.Property(t => t.CompareProductID).HasColumnName("CompareProductID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ConnectorCustomItemNumber).HasColumnName("ConnectorCustomItemNumber");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.MinPrice).HasColumnName("MinPrice");
            this.Property(t => t.MaxPrice).HasColumnName("MaxPrice");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.HotSeller).HasColumnName("HotSeller");
            this.Property(t => t.PriceIndex).HasColumnName("PriceIndex");
            this.Property(t => t.UPID).HasColumnName("UPID");
            this.Property(t => t.EAN).HasColumnName("EAN");
            this.Property(t => t.SourceProductID).HasColumnName("SourceProductID");
            this.Property(t => t.AveragePrice).HasColumnName("AveragePrice");
            this.Property(t => t.TotalStock).HasColumnName("TotalStock");
            this.Property(t => t.MinStock).HasColumnName("MinStock");
            this.Property(t => t.MaxStock).HasColumnName("MaxStock");
            this.Property(t => t.PriceGroup1Percentage).HasColumnName("PriceGroup1Percentage");
            this.Property(t => t.PriceGroup2Percentage).HasColumnName("PriceGroup2Percentage");
            this.Property(t => t.PriceGroup3Percentage).HasColumnName("PriceGroup3Percentage");
            this.Property(t => t.PriceGroup4Percentage).HasColumnName("PriceGroup4Percentage");
            this.Property(t => t.PriceGroup5Percentage).HasColumnName("PriceGroup5Percentage");
            this.Property(t => t.TotalSales).HasColumnName("TotalSales");
            this.Property(t => t.Popularity).HasColumnName("Popularity");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LastImport).HasColumnName("LastImport");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductCompares)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ProductCompareSource)
                .WithMany(t => t.ProductCompares)
                .HasForeignKey(d => d.ProductCompareSourceID);

        }
    }
}
