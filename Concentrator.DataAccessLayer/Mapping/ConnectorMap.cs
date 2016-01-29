using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorMap : EntityTypeConfiguration<Connector>
    {
        public ConnectorMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BackendEanIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.Connection)
                .HasMaxLength(255);

            this.Property(t => t.OutboundUrl)
                .HasMaxLength(255);

            this.Property(t => t.DefaultImage)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Connector");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ConnectorType).HasColumnName("ConnectorType");
            this.Property(t => t.ConnectorSystemID).HasColumnName("ConnectorSystemID");
            this.Property(t => t.ConcatenateBrandName).HasColumnName("ConcatenateBrandName");
            this.Property(t => t.ObsoleteProducts).HasColumnName("ObsoleteProducts");
            this.Property(t => t.ZipCodes).HasColumnName("ZipCodes");
            this.Property(t => t.Selectors).HasColumnName("Selectors");
            this.Property(t => t.OverrideDescriptions).HasColumnName("OverrideDescriptions");
            this.Property(t => t.BSKIdentifier).HasColumnName("BSKIdentifier");
            this.Property(t => t.BackendEanIdentifier).HasColumnName("BackendEanIdentifier");
            this.Property(t => t.UseConcentratorProductID).HasColumnName("UseConcentratorProductID");
            this.Property(t => t.Connection).HasColumnName("Connection");
            this.Property(t => t.ImportCommercialText).HasColumnName("ImportCommercialText");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.AdministrativeVendorID).HasColumnName("AdministrativeVendorID");
            this.Property(t => t.OutboundUrl).HasColumnName("OutboundUrl");
            this.Property(t => t.ParentConnectorID).HasColumnName("ParentConnectorID");
            this.Property(t => t.DefaultImage).HasColumnName("DefaultImage");
            this.Property(t => t.ConnectorSystemType).HasColumnName("ConnectorSystemType");
            this.Property(t => t.IgnoreMissingImage).HasColumnName("IgnoreMissingImage");
            this.Property(t => t.IgnoreMissingConcentratorDescription).HasColumnName("IgnoreMissingConcentratorDescription");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");

            // Relationships
            //this.HasMany(t => t.MasterGroupMappings1)
            //    .WithMany(t => t.Connectors)
            //    .Map(m =>
            //        {
            //            m.ToTable("ProductGroupMappingConnectorNotActive");
            //            m.MapLeftKey("ConnectorID");
            //            m.MapRightKey("MasterGroupMappingID");
            //        });

            this.HasOptional(t => t.Connector2)
                .WithMany(t => t.Connector1)
                .HasForeignKey(d => d.ParentConnectorID);
            this.HasOptional(t => t.ConnectorSystem)
                .WithMany(t => t.Connectors)
                .HasForeignKey(d => d.ConnectorSystemID);
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Connectors)
                .HasForeignKey(d => d.OrganizationID);
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.Connectors)
                .HasForeignKey(d => d.AdministrativeVendorID);

        }
    }
}
