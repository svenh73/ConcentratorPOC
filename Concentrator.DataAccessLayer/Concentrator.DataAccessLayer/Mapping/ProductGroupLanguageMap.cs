using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupLanguageMap : EntityTypeConfiguration<ProductGroupLanguage>
    {
        public ProductGroupLanguageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupID, t.LanguageID });

            // Properties
            this.Property(t => t.ProductGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductGroupLanguage");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductGroupLanguages)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupLanguages)
                .HasForeignKey(d => d.ProductGroupID);

        }
    }
}
