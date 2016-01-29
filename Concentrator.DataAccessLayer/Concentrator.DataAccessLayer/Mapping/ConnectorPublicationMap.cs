using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorPublicationMap : EntityTypeConfiguration<ConnectorPublication>
    {
        public ConnectorPublicationMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorPublicationID);

            // Properties
            this.Property(t => t.AttributeValue)
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("ConnectorPublication");
            this.Property(t => t.ConnectorPublicationID).HasColumnName("ConnectorPublicationID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Publish).HasColumnName("Publish");
            this.Property(t => t.PublishOnlyStock).HasColumnName("PublishOnlyStock");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ProductContentIndex).HasColumnName("ProductContentIndex");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");

            // Relationships
            this.HasOptional(t => t.AssortmentStatus)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.StatusID);
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.AttributeID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ConnectorPublications)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
