using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingSettingOptionMap : EntityTypeConfiguration<MasterGroupMappingSettingOption>
    {
        public MasterGroupMappingSettingOptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MasterGroupMappingSettingID, t.OptionID });

            // Properties
            this.Property(t => t.MasterGroupMappingSettingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingSettingOption");
            this.Property(t => t.MasterGroupMappingSettingID).HasColumnName("MasterGroupMappingSettingID");
            this.Property(t => t.OptionID).HasColumnName("OptionID");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.MasterGroupMappingSetting)
                .WithMany(t => t.MasterGroupMappingSettingOptions)
                .HasForeignKey(d => d.MasterGroupMappingSettingID);

        }
    }
}
