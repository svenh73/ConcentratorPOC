using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingDescriptionMap : EntityTypeConfiguration<MasterGroupMappingDescription>
    {
        public MasterGroupMappingDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MasterGroupMappingID, t.LanguageID });

            // Properties
            this.Property(t => t.MasterGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingDescription");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.MasterGroupMappingDescriptions)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingDescriptions)
                .HasForeignKey(d => d.MasterGroupMappingID);

        }
    }
}
