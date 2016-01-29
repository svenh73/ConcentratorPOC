using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MagentoProductGroupSettingMap : EntityTypeConfiguration<MagentoProductGroupSetting>
    {
        public MagentoProductGroupSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.MagentoProductGroupSettingID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MagentoProductGroupSetting");
            this.Property(t => t.MagentoProductGroupSettingID).HasColumnName("MagentoProductGroupSettingID");
            this.Property(t => t.ProductGroupmappingID).HasColumnName("ProductGroupmappingID");
            this.Property(t => t.ShowInMenu).HasColumnName("ShowInMenu");
            this.Property(t => t.DisabledMenu).HasColumnName("DisabledMenu");
            this.Property(t => t.IsAnchor).HasColumnName("IsAnchor");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");

            // Relationships
            this.HasOptional(t => t.MasterGroupMapping)
                .WithMany(t => t.MagentoProductGroupSettings)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasOptional(t => t.ProductGroupMapping)
                .WithMany(t => t.MagentoProductGroupSettings)
                .HasForeignKey(d => d.ProductGroupmappingID);

        }
    }
}
