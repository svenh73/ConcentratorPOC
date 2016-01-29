using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompare
    {
        public ProductCompare()
        {
            this.ProductCompetitorPrices = new List<ProductCompetitorPrice>();
        }

        public int CompareProductID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public string ConnectorCustomItemNumber { get; set; }
        public string VendorItemNumber { get; set; }
        public Nullable<decimal> MinPrice { get; set; }
        public Nullable<decimal> MaxPrice { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public int ProductCompareSourceID { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<bool> HotSeller { get; set; }
        public Nullable<decimal> PriceIndex { get; set; }
        public string UPID { get; set; }
        public string EAN { get; set; }
        public string SourceProductID { get; set; }
        public Nullable<decimal> AveragePrice { get; set; }
        public Nullable<int> TotalStock { get; set; }
        public Nullable<int> MinStock { get; set; }
        public Nullable<int> MaxStock { get; set; }
        public Nullable<decimal> PriceGroup1Percentage { get; set; }
        public Nullable<decimal> PriceGroup2Percentage { get; set; }
        public Nullable<decimal> PriceGroup3Percentage { get; set; }
        public Nullable<decimal> PriceGroup4Percentage { get; set; }
        public Nullable<decimal> PriceGroup5Percentage { get; set; }
        public Nullable<decimal> TotalSales { get; set; }
        public Nullable<decimal> Popularity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime LastImport { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductCompareSource ProductCompareSource { get; set; }
        public virtual ICollection<ProductCompetitorPrice> ProductCompetitorPrices { get; set; }
    }
}
