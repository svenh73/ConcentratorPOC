using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class FaqProductMap : EntityTypeConfiguration<FaqProduct>
    {
        public FaqProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.FaqID, t.LanguageID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FaqID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Answer)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("FaqProduct");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.FaqID).HasColumnName("FaqID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Faq)
                .WithMany(t => t.FaqProducts)
                .HasForeignKey(d => d.FaqID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.FaqProducts)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.FaqProducts)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
