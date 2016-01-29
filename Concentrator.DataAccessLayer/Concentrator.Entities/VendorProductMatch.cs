using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorProductMatch
    {
        public int VendorProductMatchID { get; set; }
        public int VendorID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> VendorProductID { get; set; }
        public string VendorItemNumber { get; set; }
        public Nullable<int> MatchPercentage { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
