using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingSettingTemplateMap : EntityTypeConfiguration<MasterGroupMappingSettingTemplate>
    {
        public MasterGroupMappingSettingTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingSettingTemplateID);

            // Properties
            this.Property(t => t.DefaultValue)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingSettingTemplate");
            this.Property(t => t.MasterGroupMappingSettingTemplateID).HasColumnName("MasterGroupMappingSettingTemplateID");
            this.Property(t => t.MasterGroupMappingSettingID).HasColumnName("MasterGroupMappingSettingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");

            // Relationships
            this.HasRequired(t => t.MasterGroupMappingSetting)
                .WithMany(t => t.MasterGroupMappingSettingTemplates)
                .HasForeignKey(d => d.MasterGroupMappingSettingID);

        }
    }
}
