using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentVendorSettingMap : EntityTypeConfiguration<ContentVendorSetting>
    {
        public ContentVendorSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentVendorSettingID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContentVendorSetting");
            this.Property(t => t.ContentVendorSettingID).HasColumnName("ContentVendorSettingID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ContentVendorIndex).HasColumnName("ContentVendorIndex");

            // Relationships
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.ContentVendorSettings)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ContentVendorSettings)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ContentVendorSettings)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ContentVendorSettings)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ContentVendorSettings)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
