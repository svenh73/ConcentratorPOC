using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorPriceRule
    {
        public VendorPriceRule()
        {
            this.VendorPrices = new List<VendorPrice>();
        }

        public int VendorPriceRuleID { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> VendorPriceCalculationID { get; set; }
        public string Margin { get; set; }
        public Nullable<decimal> UnitPriceIncrease { get; set; }
        public Nullable<decimal> CostPriceIncrease { get; set; }
        public Nullable<int> MinimumQuantity { get; set; }
        public int VendorPriceRuleIndex { get; set; }
        public Nullable<int> PriceRuleType { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<VendorPrice> VendorPrices { get; set; }
        public virtual VendorPriceCalculation VendorPriceCalculation { get; set; }
    }
}
