using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupMappingDescriptionMap : EntityTypeConfiguration<ProductGroupMappingDescription>
    {
        public ProductGroupMappingDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupMappingID, t.LanguageID });

            // Properties
            this.Property(t => t.ProductGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductGroupMappingDescription");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductGroupMappingDescriptions)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductGroupMapping)
                .WithMany(t => t.ProductGroupMappingDescriptions)
                .HasForeignKey(d => d.ProductGroupMappingID);

        }
    }
}
