using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeGroupNameMap : EntityTypeConfiguration<ProductAttributeGroupName>
    {
        public ProductAttributeGroupNameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductAttributeGroupID, t.LanguageID });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.ProductAttributeGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductAttributeGroupName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ProductAttributeGroupID).HasColumnName("ProductAttributeGroupID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductAttributeGroupNames)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductAttributeGroupMetaData)
                .WithMany(t => t.ProductAttributeGroupNames)
                .HasForeignKey(d => d.ProductAttributeGroupID);

        }
    }
}
