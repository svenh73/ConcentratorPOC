using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ScanProviderMap : EntityTypeConfiguration<ScanProvider>
    {
        public ScanProviderMap()
        {
            // Primary Key
            this.HasKey(t => t.ScanProviderID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScanProvider");
            this.Property(t => t.ScanProviderID).HasColumnName("ScanProviderID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.IncludeShippingCost).HasColumnName("IncludeShippingCost");

            // Relationships
            this.HasRequired(t => t.ScanProvider2)
                .WithOptional(t => t.ScanProvider1);

        }
    }
}
