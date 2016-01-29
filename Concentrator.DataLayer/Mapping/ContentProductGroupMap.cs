using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentProductGroupMap : EntityTypeConfiguration<ContentProductGroup>
    {
        public ContentProductGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentProductGroupID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContentProductGroup");
            this.Property(t => t.ContentProductGroupID).HasColumnName("ContentProductGroupID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.IsCustom).HasColumnName("IsCustom");
            this.Property(t => t.Exists).HasColumnName("Exists");
            this.Property(t => t.IsExported).HasColumnName("IsExported");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ContentProductGroups)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.MasterGroupMapping)
                .WithMany(t => t.ContentProductGroups)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ContentProductGroups)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.ProductGroupMapping)
                .WithMany(t => t.ContentProductGroups)
                .HasForeignKey(d => d.ProductGroupMappingID);

        }
    }
}
