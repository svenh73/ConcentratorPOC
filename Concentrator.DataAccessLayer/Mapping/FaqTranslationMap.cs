using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class FaqTranslationMap : EntityTypeConfiguration<FaqTranslation>
    {
        public FaqTranslationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FaqID, t.LanguageID });

            // Properties
            this.Property(t => t.FaqID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("FaqTranslation");
            this.Property(t => t.FaqID).HasColumnName("FaqID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Faq)
                .WithMany(t => t.FaqTranslations)
                .HasForeignKey(d => d.FaqID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.FaqTranslations)
                .HasForeignKey(d => d.LanguageID);

        }
    }
}
