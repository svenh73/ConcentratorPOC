using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingSettingMap : EntityTypeConfiguration<MasterGroupMappingSetting>
    {
        public MasterGroupMappingSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingSettingID);

            // Properties
            this.Property(t => t.Group)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingSetting");
            this.Property(t => t.MasterGroupMappingSettingID).HasColumnName("MasterGroupMappingSettingID");
            this.Property(t => t.Group).HasColumnName("Group");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
