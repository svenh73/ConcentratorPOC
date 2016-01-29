using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentStock
    {
        public int VendorID { get; set; }
        public int ConnectorID { get; set; }
        public int VendorStockTypeID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual VendorStockType VendorStockType { get; set; }
    }
}
