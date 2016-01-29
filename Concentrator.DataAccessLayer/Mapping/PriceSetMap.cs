using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PriceSetMap : EntityTypeConfiguration<PriceSet>
    {
        public PriceSetMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceSetID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PriceSet");
            this.Property(t => t.PriceSetID).HasColumnName("PriceSetID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.IsCatalog).HasColumnName("IsCatalog");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.DiscountPercentage).HasColumnName("DiscountPercentage");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.PriceSets)
                .HasForeignKey(d => d.ConnectorID);

        }
    }
}
