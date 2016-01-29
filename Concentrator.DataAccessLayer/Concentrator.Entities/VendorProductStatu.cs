using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorProductStatu
    {
        public int VendorID { get; set; }
        public string VendorStatus { get; set; }
        public int ConcentratorStatusID { get; set; }
        public Nullable<int> VendorStatusID { get; set; }
        public int VendorProductStatusID { get; set; }
        public virtual AssortmentStatu AssortmentStatu { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
