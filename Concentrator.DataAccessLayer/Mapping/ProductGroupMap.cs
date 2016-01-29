using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupMap : EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductGroupID);

            // Properties
            this.Property(t => t.ImagePath)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductGroup");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Searchable).HasColumnName("Searchable");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
        }
    }
}
