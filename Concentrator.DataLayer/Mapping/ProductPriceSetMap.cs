using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductPriceSetMap : EntityTypeConfiguration<ProductPriceSet>
    {
        public ProductPriceSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PriceSetID, t.ProductID });

            // Properties
            this.Property(t => t.PriceSetID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductPriceSet");
            this.Property(t => t.PriceSetID).HasColumnName("PriceSetID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");

            // Relationships
            this.HasRequired(t => t.PriceSet)
                .WithMany(t => t.ProductPriceSets)
                .HasForeignKey(d => d.PriceSetID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductPriceSets)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
