using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PreferredConnectorVendor
    {
        public int VendorID { get; set; }
        public int ConnectorID { get; set; }
        public bool isPreferred { get; set; }
        public bool isContentVisible { get; set; }
        public string VendorIdentifier { get; set; }
        public bool CentralDelivery { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
