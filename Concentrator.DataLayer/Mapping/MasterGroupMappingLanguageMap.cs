using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingLanguageMap : EntityTypeConfiguration<MasterGroupMappingLanguage>
    {
        public MasterGroupMappingLanguageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MasterGroupMappingID, t.LanguageID });

            // Properties
            this.Property(t => t.MasterGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingLanguage");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.MasterGroupMappingLanguages)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingLanguages)
                .HasForeignKey(d => d.MasterGroupMappingID);

        }
    }
}
