using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupMappingMap : EntityTypeConfiguration<ProductGroupMapping>
    {
        public ProductGroupMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductGroupMappingID);

            // Properties
            this.Property(t => t.Lineage)
                .HasMaxLength(255);

            this.Property(t => t.CustomProductGroupLabel)
                .HasMaxLength(255);

            this.Property(t => t.ProductGroupMappingLabel)
                .HasMaxLength(255);

            this.Property(t => t.ProductGroupMappingPath)
                .HasMaxLength(255);

            this.Property(t => t.BackendMatchingLabel)
                .HasMaxLength(200);

            this.Property(t => t.MappingThumbnailImagePath)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ProductGroupMapping");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.ParentProductGroupMappingID).HasColumnName("ParentProductGroupMappingID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.FlattenHierarchy).HasColumnName("FlattenHierarchy");
            this.Property(t => t.FilterByParentGroup).HasColumnName("FilterByParentGroup");
            this.Property(t => t.Depth).HasColumnName("Depth");
            this.Property(t => t.Lineage).HasColumnName("Lineage");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.CustomProductGroupLabel).HasColumnName("CustomProductGroupLabel");
            this.Property(t => t.ProductGroupMappingLabel).HasColumnName("ProductGroupMappingLabel");
            this.Property(t => t.ProductGroupMappingPath).HasColumnName("ProductGroupMappingPath");
            this.Property(t => t.Relation).HasColumnName("Relation");
            this.Property(t => t.MagentoPageLayoutID).HasColumnName("MagentoPageLayoutID");
            this.Property(t => t.BackendMatchingLabel).HasColumnName("BackendMatchingLabel");
            this.Property(t => t.MappingThumbnailImagePath).HasColumnName("MappingThumbnailImagePath");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ProductGroupMappings)
                .HasForeignKey(d => d.ConnectorID).WillCascadeOnDelete(false);
            this.HasOptional(t => t.MagentoPageLayout)
                .WithMany(t => t.ProductGroupMappings)
                .HasForeignKey(d => d.MagentoPageLayoutID);
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupMappings)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasOptional(t => t.ProductGroupMapping2)
                .WithMany(t => t.ProductGroupMapping1)
                .HasForeignKey(d => d.ParentProductGroupMappingID);
            this.HasOptional(t => t.ProductGroupMapping3)
                .WithMany(t => t.ProductGroupMapping11)
                .HasForeignKey(d => d.ParentProductGroupMappingID);

        }
    }
}
