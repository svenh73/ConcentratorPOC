using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class AttributeOptionTranslationMap : EntityTypeConfiguration<AttributeOptionTranslation>
    {
        public AttributeOptionTranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Translation)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AttributeOptionTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeOptionId).HasColumnName("AttributeOptionId");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.Translation).HasColumnName("Translation");

            // Relationships
            this.HasRequired(t => t.AttributeOption)
                .WithMany(t => t.AttributeOptionTranslations)
                .HasForeignKey(d => d.AttributeOptionId);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.AttributeOptionTranslations)
                .HasForeignKey(d => d.LanguageId);

        }
    }
}
