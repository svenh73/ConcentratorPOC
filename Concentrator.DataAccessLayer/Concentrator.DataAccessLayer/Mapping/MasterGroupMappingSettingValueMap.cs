using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingSettingValueMap : EntityTypeConfiguration<MasterGroupMappingSettingValue>
    {
        public MasterGroupMappingSettingValueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MasterGroupMappingID, t.MasterGroupMappingSettingID });

            // Properties
            this.Property(t => t.MasterGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MasterGroupMappingSettingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingSettingValue");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.MasterGroupMappingSettingID).HasColumnName("MasterGroupMappingSettingID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");

            // Relationships
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingSettingValues)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasRequired(t => t.MasterGroupMappingSetting)
                .WithMany(t => t.MasterGroupMappingSettingValues)
                .HasForeignKey(d => d.MasterGroupMappingSettingID);

        }
    }
}
