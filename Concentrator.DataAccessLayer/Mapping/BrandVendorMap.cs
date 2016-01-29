using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class BrandVendorMap : EntityTypeConfiguration<BrandVendor>
    {
        public BrandVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BrandID, t.VendorID, t.VendorBrandCode });

            // Properties
            this.Property(t => t.BrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorBrandCode)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Name)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("BrandVendor");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorBrandCode).HasColumnName("VendorBrandCode");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandVendors)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
