using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorProductStatuMap : EntityTypeConfiguration<VendorProductStatus>
    {
        public VendorProductStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorProductStatusID);

            // Properties
            this.Property(t => t.VendorStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorProductStatus");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorStatus).HasColumnName("VendorStatus");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.VendorStatusID).HasColumnName("VendorStatusID");
            this.Property(t => t.VendorProductStatusID).HasColumnName("VendorProductStatusID");

            // Relationships
            this.HasRequired(t => t.AssortmentStatus)
                .WithMany(t => t.VendorProductStatus)
                .HasForeignKey(d => d.ConcentratorStatusID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorProductStatus)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
