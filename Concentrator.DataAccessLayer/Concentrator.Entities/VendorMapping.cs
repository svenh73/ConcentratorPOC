using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorMapping
    {
        public int VendorMappingID { get; set; }
        public int VendorID { get; set; }
        public int MapVendorID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Vendor Vendor1 { get; set; }
    }
}
