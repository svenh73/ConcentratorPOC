using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class AdditionalOrderProduct
    {
        public int AdditionalOrderProductID { get; set; }
        public int ConnectorID { get; set; }
        public string ConnectorProductID { get; set; }
        public int VendorID { get; set; }
        public string VendorProductID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
