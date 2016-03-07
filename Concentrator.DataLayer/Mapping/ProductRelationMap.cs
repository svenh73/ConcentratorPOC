using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class ProductRelationMap : EntityTypeConfiguration<ProductRelation>
    {
        public ProductRelationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductId, t.RelatedProductId });

            // Properties
            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RelatedProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductRelation");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.RelatedProductId).HasColumnName("RelatedProductId");
            this.Property(t => t.RelatedProductTypeId).HasColumnName("RelatedProductTypeId");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductRelations)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.ProductRelationType)
                .WithMany(t => t.ProductRelations)
                .HasForeignKey(d => d.RelatedProductTypeId);

        }
    }
}
