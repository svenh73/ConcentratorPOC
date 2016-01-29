using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompetitorMappingMap : EntityTypeConfiguration<ProductCompetitorMapping>
    {
        public ProductCompetitorMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductCompetitorMappingID);

            // Properties
            this.Property(t => t.Competitor)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ProductCompetitorMapping");
            this.Property(t => t.ProductCompetitorMappingID).HasColumnName("ProductCompetitorMappingID");
            this.Property(t => t.Competitor).HasColumnName("Competitor");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
            this.Property(t => t.ProductCompetitorID).HasColumnName("ProductCompetitorID");
            this.Property(t => t.IncludeShippingCost).HasColumnName("IncludeShippingCost");
            this.Property(t => t.InTaxPrice).HasColumnName("InTaxPrice");

            // Relationships
            this.HasRequired(t => t.ProductCompareSource)
                .WithMany(t => t.ProductCompetitorMappings)
                .HasForeignKey(d => d.ProductCompareSourceID);
            this.HasOptional(t => t.ProductCompetitor)
                .WithMany(t => t.ProductCompetitorMappings)
                .HasForeignKey(d => d.ProductCompetitorID);

        }
    }
}
