using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupContentVendorMap : EntityTypeConfiguration<ProductGroupContentVendor>
    {
        public ProductGroupContentVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupID, t.VendorID });

            // Properties
            this.Property(t => t.ProductGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContentVendorProductGroupCode)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductGroupContentVendor");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ContentVendorProductGroupCode).HasColumnName("ContentVendorProductGroupCode");
            this.Property(t => t.ContentVendorProductGroupID).HasColumnName("ContentVendorProductGroupID");

            // Relationships
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupContentVendors)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductGroupContentVendors)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
