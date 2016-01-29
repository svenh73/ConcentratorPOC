using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class AdditionalOrderProductMap : EntityTypeConfiguration<AdditionalOrderProduct>
    {
        public AdditionalOrderProductMap()
        {
            // Primary Key
            this.HasKey(t => t.AdditionalOrderProductID);

            // Properties
            this.Property(t => t.ConnectorProductID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorProductID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AdditionalOrderProduct");
            this.Property(t => t.AdditionalOrderProductID).HasColumnName("AdditionalOrderProductID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ConnectorProductID).HasColumnName("ConnectorProductID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorProductID).HasColumnName("VendorProductID");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.AdditionalOrderProducts)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.AdditionalOrderProducts)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
