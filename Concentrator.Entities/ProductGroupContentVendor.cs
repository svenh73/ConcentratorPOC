using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupContentVendor
    {
        public int ProductGroupID { get; set; }
        public int VendorID { get; set; }
        public string ContentVendorProductGroupCode { get; set; }
        public Nullable<int> ContentVendorProductGroupID { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
