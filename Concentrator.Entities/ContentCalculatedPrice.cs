using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentCalculatedPrice
    {
        public int ProductID { get; set; }
        public Nullable<decimal> PriceEx { get; set; }
        public Nullable<decimal> priceInc { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public Nullable<decimal> minPriceInc { get; set; }
        public Nullable<decimal> maxPriceInc { get; set; }
        public Nullable<int> competitorcount { get; set; }
        public Nullable<long> RankNumber { get; set; }
        public Nullable<decimal> OwnPriceInc { get; set; }
        public Nullable<decimal> AverageMarketPriceInc { get; set; }
        public Nullable<int> CurrentRank { get; set; }
        public Nullable<int> ConcentratorStatusID { get; set; }
        public string CommercialStatus { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<int> MinimumQuantity { get; set; }
        public string ContentPriceLabel { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<decimal> BottomMargin { get; set; }
        public Nullable<int> ComparePricePosition { get; set; }
        public Nullable<int> MinComparePricePosition { get; set; }
        public Nullable<int> MaxComparePricePosition { get; set; }
        public string CustomItemNumber { get; set; }
        public string ShortDescription { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<System.DateTime> lastImport { get; set; }
        public string CompetitorStock { get; set; }
        public Nullable<int> BrandID { get; set; }
        public string VendorItemNumber { get; set; }
        public int ConnectorID { get; set; }
        public string CompetitorSource { get; set; }
        public Nullable<int> ProductCompareSourceID { get; set; }
    }
}
