using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorMappingMap : EntityTypeConfiguration<VendorMapping>
    {
        public VendorMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorMappingID);

            // Properties
            // Table & Column Mappings
            this.ToTable("VendorMapping");
            this.Property(t => t.VendorMappingID).HasColumnName("VendorMappingID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.MapVendorID).HasColumnName("MapVendorID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorMappings)
                .HasForeignKey(d => d.VendorID);
            this.HasRequired(t => t.Vendor1)
                .WithMany(t => t.VendorMappings1)
                .HasForeignKey(d => d.MapVendorID);

        }
    }
}
