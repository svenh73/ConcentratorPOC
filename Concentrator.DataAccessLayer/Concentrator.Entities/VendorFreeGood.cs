using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorFreeGood
    {
        public int VendorAssortmentID { get; set; }
        public int ProductID { get; set; }
        public int MinimumQuantity { get; set; }
        public int OverOrderedQuantity { get; set; }
        public int FreeGoodQuantity { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual VendorAssortment VendorAssortment { get; set; }
    }
}
