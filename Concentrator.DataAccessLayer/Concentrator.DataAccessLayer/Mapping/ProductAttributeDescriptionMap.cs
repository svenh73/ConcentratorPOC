using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeDescriptionMap : EntityTypeConfiguration<ProductAttributeDescription>
    {
        public ProductAttributeDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AttributeID, t.LanguageID });

            // Properties
            this.Property(t => t.AttributeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1500);

            // Table & Column Mappings
            this.ToTable("ProductAttributeDescription");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductAttributeDescriptions)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeDescriptions)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
