using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupConnectorVendorMap : EntityTypeConfiguration<ProductGroupConnectorVendor>
    {
        public ProductGroupConnectorVendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupID, t.ConnectorID, t.VendorID });

            // Properties
            this.Property(t => t.ProductGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductGroupConnectorVendor");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.isPreferredAssortmentVendor).HasColumnName("isPreferredAssortmentVendor");
            this.Property(t => t.isPreferredContentVendor).HasColumnName("isPreferredContentVendor");
            this.Property(t => t.VendorID).HasColumnName("VendorID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ProductGroupConnectorVendors)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupConnectorVendors)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductGroupConnectorVendors)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
