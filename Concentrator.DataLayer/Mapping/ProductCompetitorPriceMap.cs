using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompetitorPriceMap : EntityTypeConfiguration<ProductCompetitorPrice>
    {
        public ProductCompetitorPriceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductCompetitorPriceID);

            // Properties
            this.Property(t => t.Stock)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCompetitorPrice");
            this.Property(t => t.ProductCompetitorPriceID).HasColumnName("ProductCompetitorPriceID");
            this.Property(t => t.ProductCompetitorMappingID).HasColumnName("ProductCompetitorMappingID");
            this.Property(t => t.CompareProductID).HasColumnName("CompareProductID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Stock).HasColumnName("Stock");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastImport).HasColumnName("LastImport");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ProductCompetitorPrices)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductCompare)
                .WithMany(t => t.ProductCompetitorPrices)
                .HasForeignKey(d => d.CompareProductID);
            this.HasRequired(t => t.ProductCompetitorMapping)
                .WithMany(t => t.ProductCompetitorPrices)
                .HasForeignKey(d => d.ProductCompetitorMappingID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ProductCompetitorPrices)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.ProductCompetitorPrices1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);

        }
    }
}
