using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentPrice
    {
        public int ContentPriceRuleID { get; set; }
        public int VendorID { get; set; }
        public int ConnectorID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Margin { get; set; }
        public Nullable<decimal> UnitPriceIncrease { get; set; }
        public Nullable<decimal> CostPriceIncrease { get; set; }
        public Nullable<int> MinimumQuantity { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public int ContentPriceRuleIndex { get; set; }
        public Nullable<int> PriceRuleType { get; set; }
        public Nullable<int> ContentPriceCalculationID { get; set; }
        public Nullable<decimal> FixedPrice { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<decimal> BottomMargin { get; set; }
        public Nullable<int> ComparePricePosition { get; set; }
        public Nullable<int> MinComparePricePosition { get; set; }
        public Nullable<int> MaxComparePricePosition { get; set; }
        public Nullable<decimal> SellMargin { get; set; }
        public string ContentPriceLabel { get; set; }
        public Nullable<int> CompareSourceID { get; set; }
        public Nullable<int> AttributeID { get; set; }
        public string AttributeValue { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductCompareSource ProductCompareSource { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ContentPriceCalculation ContentPriceCalculation { get; set; }
    }
}
