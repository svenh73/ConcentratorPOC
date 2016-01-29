using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupConnectorVendor
    {
        public int ProductGroupID { get; set; }
        public int ConnectorID { get; set; }
        public bool isPreferredAssortmentVendor { get; set; }
        public bool isPreferredContentVendor { get; set; }
        public int VendorID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
