using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorAccruel
    {
        public int VendorAssortmentID { get; set; }
        public string AccruelCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int MinimumQuantity { get; set; }
        public virtual VendorAssortment VendorAssortment { get; set; }
    }
}
