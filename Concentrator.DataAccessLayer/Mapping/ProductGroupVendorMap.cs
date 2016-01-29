using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupVendorMap : EntityTypeConfiguration<ProductGroupVendor>
    {
        public ProductGroupVendorMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductGroupVendorID);

            // Properties
            this.Property(t => t.VendorName)
                .HasMaxLength(200);

            this.Property(t => t.BrandCode)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode1)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode2)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode3)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode4)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode5)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode6)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode7)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode8)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode9)
                .HasMaxLength(50);

            this.Property(t => t.VendorProductGroupCode10)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductGroupVendor");
            this.Property(t => t.ProductGroupVendorID).HasColumnName("ProductGroupVendorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorName).HasColumnName("VendorName");
            this.Property(t => t.BrandCode).HasColumnName("BrandCode");
            this.Property(t => t.VendorProductGroupCode1).HasColumnName("VendorProductGroupCode1");
            this.Property(t => t.VendorProductGroupCode2).HasColumnName("VendorProductGroupCode2");
            this.Property(t => t.VendorProductGroupCode3).HasColumnName("VendorProductGroupCode3");
            this.Property(t => t.VendorProductGroupCode4).HasColumnName("VendorProductGroupCode4");
            this.Property(t => t.VendorProductGroupCode5).HasColumnName("VendorProductGroupCode5");
            this.Property(t => t.VendorProductGroupCode6).HasColumnName("VendorProductGroupCode6");
            this.Property(t => t.VendorProductGroupCode7).HasColumnName("VendorProductGroupCode7");
            this.Property(t => t.VendorProductGroupCode8).HasColumnName("VendorProductGroupCode8");
            this.Property(t => t.VendorProductGroupCode9).HasColumnName("VendorProductGroupCode9");
            this.Property(t => t.VendorProductGroupCode10).HasColumnName("VendorProductGroupCode10");
            this.Property(t => t.IsBlocked).HasColumnName("IsBlocked");

            // Relationships
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupVendors)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductGroupVendors)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
