using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompareSourceMap : EntityTypeConfiguration<ProductCompareSource>
    {
        public ProductCompareSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductCompareSourceID);

            // Properties
            this.Property(t => t.Source)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.ProductCompareSourceType)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductCompareSource");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
            this.Property(t => t.Source).HasColumnName("Source");
            this.Property(t => t.ProductCompareSourceParentID).HasColumnName("ProductCompareSourceParentID");
            this.Property(t => t.ProductCompareSourceType).HasColumnName("ProductCompareSourceType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasOptional(t => t.ProductCompareSource2)
                .WithMany(t => t.ProductCompareSource1)
                .HasForeignKey(d => d.ProductCompareSourceParentID);

        }
    }
}
