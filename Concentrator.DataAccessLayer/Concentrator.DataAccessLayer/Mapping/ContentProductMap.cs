using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentProductMap : EntityTypeConfiguration<ContentProduct>
    {
        public ContentProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductContentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContentProduct");
            this.Property(t => t.ProductContentID).HasColumnName("ProductContentID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ProductContentIndex).HasColumnName("ProductContentIndex");
            this.Property(t => t.IsAssortment).HasColumnName("IsAssortment");

            // Relationships
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.ContentProducts)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ContentProducts)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ContentProducts)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ContentProducts)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ContentProducts)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
