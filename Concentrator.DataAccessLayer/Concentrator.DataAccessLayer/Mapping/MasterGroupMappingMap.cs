using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingMap : EntityTypeConfiguration<MasterGroupMapping>
    {
        public MasterGroupMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingID);

            // Properties
            this.Property(t => t.CustomProductGroupLabel)
                .HasMaxLength(255);

            this.Property(t => t.BackendMatchingLabel)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("MasterGroupMapping");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.ParentMasterGroupMappingID).HasColumnName("ParentMasterGroupMappingID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.SourceMasterGroupMappingID).HasColumnName("SourceMasterGroupMappingID");
            this.Property(t => t.FlattenHierarchy).HasColumnName("FlattenHierarchy");
            this.Property(t => t.FilterByParentGroup).HasColumnName("FilterByParentGroup");
            this.Property(t => t.ExportID).HasColumnName("ExportID");
            this.Property(t => t.SourceProductGroupMappingID).HasColumnName("SourceProductGroupMappingID");
            this.Property(t => t.CustomProductGroupLabel).HasColumnName("CustomProductGroupLabel");
            this.Property(t => t.BackendMatchingLabel).HasColumnName("BackendMatchingLabel");
            this.Property(t => t.MagentoPageLayoutID).HasColumnName("MagentoPageLayoutID");

            // Relationships
            this.HasMany(t => t.ProductAttributeMetaDatas)
                .WithMany(t => t.MasterGroupMappings)
                .Map(m =>
                    {
                        m.ToTable("MasterGroupMappingAttributeValue");
                        m.MapLeftKey("MasterGroupMappingID");
                        m.MapRightKey("AttributeID");
                    });

            this.HasMany(t => t.MasterGroupMapping13)
                .WithMany(t => t.MasterGroupMappings)
                .Map(m =>
                    {
                        m.ToTable("MasterGroupMappingCrossReference");
                        m.MapLeftKey("MasterGroupMappingID");
                        m.MapRightKey("CrossReferenceID");
                    });

            this.HasMany(t => t.ProductGroupVendors)
                .WithMany(t => t.MasterGroupMappings)
                .Map(m =>
                    {
                        m.ToTable("MasterGroupMappingProductGroupVendor");
                        m.MapLeftKey("MasterGroupMappingID");
                        m.MapRightKey("ProductGroupVendorID");
                    });

            this.HasOptional(t => t.Connector)
                .WithMany(t => t.MasterGroupMappings)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.MagentoPageLayout)
                .WithMany(t => t.MasterGroupMappings)
                .HasForeignKey(d => d.MagentoPageLayoutID);
            this.HasOptional(t => t.MasterGroupMapping2)
                .WithMany(t => t.MasterGroupMapping1)
                .HasForeignKey(d => d.ParentMasterGroupMappingID);
            this.HasOptional(t => t.MasterGroupMapping3)
                .WithMany(t => t.MasterGroupMapping11)
                .HasForeignKey(d => d.SourceProductGroupMappingID);
            this.HasOptional(t => t.MasterGroupMapping4)
                .WithMany(t => t.MasterGroupMapping12)
                .HasForeignKey(d => d.SourceMasterGroupMappingID);
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.MasterGroupMappings)
                .HasForeignKey(d => d.ProductGroupID);

        }
    }
}
