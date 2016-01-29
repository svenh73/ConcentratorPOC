using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PriceCorrectionMap : EntityTypeConfiguration<PriceCorrection>
    {
        public PriceCorrectionMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceCorrectionID);

            // Properties
            this.Property(t => t.ProductID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AdditionalLine)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PriceCorrection");
            this.Property(t => t.PriceCorrectionID).HasColumnName("PriceCorrectionID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.AdditionalLine).HasColumnName("AdditionalLine");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
        }
    }
}
