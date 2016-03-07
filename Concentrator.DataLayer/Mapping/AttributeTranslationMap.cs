using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class AttributeTranslationMap : EntityTypeConfiguration<AttributeTranslation>
    {
        public AttributeTranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Translation)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AttributeTranslation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.Translation).HasColumnName("Translation");

            // Relationships
            this.HasRequired(t => t.Attribute)
                .WithMany(t => t.AttributeTranslations)
                .HasForeignKey(d => d.AttributeId);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.AttributeTranslations)
                .HasForeignKey(d => d.LanguageId);

        }
    }
}
