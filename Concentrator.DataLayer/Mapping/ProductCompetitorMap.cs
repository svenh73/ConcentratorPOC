using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompetitorMap : EntityTypeConfiguration<ProductCompetitor>
    {
        public ProductCompetitorMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductCompetitorID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCompetitor");
            this.Property(t => t.ProductCompetitorID).HasColumnName("ProductCompetitorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Reliability).HasColumnName("Reliability");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.ShippingCostPerOrder).HasColumnName("ShippingCostPerOrder");
            this.Property(t => t.ShippingCost).HasColumnName("ShippingCost");
        }
    }
}
