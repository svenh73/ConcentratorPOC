using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingProductVendor
    {
        public int VendorID { get; set; }
        public int ProductID { get; set; }
        public int MasterGroupMappingID { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
