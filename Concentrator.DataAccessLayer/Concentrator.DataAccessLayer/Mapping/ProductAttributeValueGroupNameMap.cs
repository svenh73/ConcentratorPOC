using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeValueGroupNameMap : EntityTypeConfiguration<ProductAttributeValueGroupName>
    {
        public ProductAttributeValueGroupNameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AttributeValueGroupID, t.LanguageID });

            // Properties
            this.Property(t => t.AttributeValueGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ProductAttributeValueGroupName");
            this.Property(t => t.AttributeValueGroupID).HasColumnName("AttributeValueGroupID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductAttributeValueGroupNames)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductAttributeValueGroup)
                .WithMany(t => t.ProductAttributeValueGroupNames)
                .HasForeignKey(d => d.AttributeValueGroupID);

        }
    }
}
