using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingProductVendorMap : EntityTypeConfiguration<MasterGroupMappingProductVendor>
    {
        public MasterGroupMappingProductVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorID, t.ProductID, t.MasterGroupMappingID });

            // Properties
            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MasterGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingProductVendor");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");

            // Relationships
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingProductVendors)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MasterGroupMappingProductVendors)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.MasterGroupMappingProductVendors)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
