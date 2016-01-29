using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorTranslationMap : EntityTypeConfiguration<VendorTranslation>
    {
        public VendorTranslationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SourceVendorID, t.SourceVendorValue, t.TranslationType });

            // Properties
            this.Property(t => t.SourceVendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SourceVendorValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DestinationVendorValue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TranslationType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VendorTranslation");
            this.Property(t => t.SourceVendorID).HasColumnName("SourceVendorID");
            this.Property(t => t.SourceVendorValue).HasColumnName("SourceVendorValue");
            this.Property(t => t.DestinationVendorID).HasColumnName("DestinationVendorID");
            this.Property(t => t.DestinationVendorValue).HasColumnName("DestinationVendorValue");
            this.Property(t => t.TranslationType).HasColumnName("TranslationType");

            // Relationships
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorTranslations)
                .HasForeignKey(d => d.DestinationVendorID);
            this.HasRequired(t => t.Vendor1)
                .WithMany(t => t.VendorTranslations1)
                .HasForeignKey(d => d.SourceVendorID);

        }
    }
}
