using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorPrice
    {
        public int VendorAssortmentID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public int MinimumQuantity { get; set; }
        public string CommercialStatus { get; set; }
        public Nullable<int> ConcentratorStatusID { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<decimal> BaseCostPrice { get; set; }
        public Nullable<int> VendorPriceRuleID { get; set; }
        public Nullable<decimal> SpecialPrice { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual AssortmentStatus AssortmentStatus { get; set; }
        public virtual VendorAssortment VendorAssortment { get; set; }
        public virtual VendorPriceRule VendorPriceRule { get; set; }
    }
}
