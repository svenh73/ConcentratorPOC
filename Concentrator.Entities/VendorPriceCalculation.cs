using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorPriceCalculation
    {
        public VendorPriceCalculation()
        {
            this.VendorPriceRules = new List<VendorPriceRule>();
        }

        public int VendorPriceCalculationID { get; set; }
        public string Name { get; set; }
        public string Calculation { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public virtual ICollection<VendorPriceRule> VendorPriceRules { get; set; }
    }
}
