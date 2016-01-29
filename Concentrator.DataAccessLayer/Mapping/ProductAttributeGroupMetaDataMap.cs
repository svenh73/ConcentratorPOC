using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeGroupMetaDataMap : EntityTypeConfiguration<ProductAttributeGroupMetaData>
    {
        public ProductAttributeGroupMetaDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductAttributeGroupID);

            // Properties
            this.Property(t => t.GroupCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductAttributeGroupMetaData");
            this.Property(t => t.ProductAttributeGroupID).HasColumnName("ProductAttributeGroupID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.GroupCode).HasColumnName("GroupCode");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.SourceGroupID).HasColumnName("SourceGroupID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductAttributeGroupMetaDatas)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductAttributeGroupMetaDatas)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
