using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductCompetitorLedgerMap : EntityTypeConfiguration<ProductCompetitorLedger>
    {
        public ProductCompetitorLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductCompetitorLedgerID);

            // Properties
            this.Property(t => t.Stock)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductCompetitorLedger");
            this.Property(t => t.ProductCompetitorLedgerID).HasColumnName("ProductCompetitorLedgerID");
            this.Property(t => t.ProductCompetitorPriceID).HasColumnName("ProductCompetitorPriceID");
            this.Property(t => t.Stock).HasColumnName("Stock");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");

            // Relationships
            this.HasRequired(t => t.ProductCompetitorPrice)
                .WithMany(t => t.ProductCompetitorLedgers)
                .HasForeignKey(d => d.ProductCompetitorPriceID);

        }
    }
}
