using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorProductStatus
    {
        public int VendorID { get; set; }
        public string VendorStatus { get; set; }
        public int ConcentratorStatusID { get; set; }
        public int? VendorStatusID { get; set; }
        public int VendorProductStatusID { get; set; }
        public virtual AssortmentStatus AssortmentStatus { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
