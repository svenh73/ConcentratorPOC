using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PreferredConnectorVendorMap : EntityTypeConfiguration<PreferredConnectorVendor>
    {
        public PreferredConnectorVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorID, t.ConnectorID });

            // Properties
            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorIdentifier)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PreferredConnectorVendor");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.isPreferred).HasColumnName("isPreferred");
            this.Property(t => t.isContentVisible).HasColumnName("isContentVisible");
            this.Property(t => t.VendorIdentifier).HasColumnName("VendorIdentifier");
            this.Property(t => t.CentralDelivery).HasColumnName("CentralDelivery");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.PreferredConnectorVendors)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.PreferredConnectorVendors)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
