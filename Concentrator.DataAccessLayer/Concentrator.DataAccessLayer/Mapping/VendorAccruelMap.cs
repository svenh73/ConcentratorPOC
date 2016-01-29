using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorAccruelMap : EntityTypeConfiguration<VendorAccruel>
    {
        public VendorAccruelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorAssortmentID, t.AccruelCode });

            // Properties
            this.Property(t => t.VendorAssortmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccruelCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VendorAccruel");
            this.Property(t => t.VendorAssortmentID).HasColumnName("VendorAssortmentID");
            this.Property(t => t.AccruelCode).HasColumnName("AccruelCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");

            // Relationships
            this.HasRequired(t => t.VendorAssortment)
                .WithMany(t => t.VendorAccruels)
                .HasForeignKey(d => d.VendorAssortmentID);

        }
    }
}
