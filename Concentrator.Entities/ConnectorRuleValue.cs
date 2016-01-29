using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorRuleValue
    {
        public int ConnectorID { get; set; }
        public int RuleID { get; set; }
        public int VendorID { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual OrderRule OrderRule { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
