using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeNameMap : EntityTypeConfiguration<ProductAttributeName>
    {
        public ProductAttributeNameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AttributeID, t.LanguageID });

            // Properties
            this.Property(t => t.AttributeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductAttributeName");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductAttributeNames)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeNames)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
