using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentCalculatedPriceMap : EntityTypeConfiguration<ContentCalculatedPrice>
    {
        public ContentCalculatedPriceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.ConnectorID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CommercialStatus)
                .HasMaxLength(100);

            this.Property(t => t.ContentPriceLabel)
                .HasMaxLength(255);

            this.Property(t => t.CustomItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(150);

            this.Property(t => t.CompetitorStock)
                .HasMaxLength(50);

            this.Property(t => t.VendorItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompetitorSource)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ContentCalculatedPrice");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.PriceEx).HasColumnName("PriceEx");
            this.Property(t => t.priceInc).HasColumnName("priceInc");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.Margin).HasColumnName("Margin");
            this.Property(t => t.minPriceInc).HasColumnName("minPriceInc");
            this.Property(t => t.maxPriceInc).HasColumnName("maxPriceInc");
            this.Property(t => t.competitorcount).HasColumnName("competitorcount");
            this.Property(t => t.RankNumber).HasColumnName("RankNumber");
            this.Property(t => t.OwnPriceInc).HasColumnName("OwnPriceInc");
            this.Property(t => t.AverageMarketPriceInc).HasColumnName("AverageMarketPriceInc");
            this.Property(t => t.CurrentRank).HasColumnName("CurrentRank");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.CommercialStatus).HasColumnName("CommercialStatus");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.ContentPriceLabel).HasColumnName("ContentPriceLabel");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.BottomMargin).HasColumnName("BottomMargin");
            this.Property(t => t.ComparePricePosition).HasColumnName("ComparePricePosition");
            this.Property(t => t.MinComparePricePosition).HasColumnName("MinComparePricePosition");
            this.Property(t => t.MaxComparePricePosition).HasColumnName("MaxComparePricePosition");
            this.Property(t => t.CustomItemNumber).HasColumnName("CustomItemNumber");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.lastImport).HasColumnName("lastImport");
            this.Property(t => t.CompetitorStock).HasColumnName("CompetitorStock");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.CompetitorSource).HasColumnName("CompetitorSource");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
        }
    }
}
