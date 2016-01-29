using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Outbound
    {
        public int OutboundID { get; set; }
        public string OutboundMessage { get; set; }
        public int ConnectorID { get; set; }
        public bool Processed { get; set; }
        public System.DateTime CreationTime { get; set; }
        public string Type { get; set; }
        public string OutboundUrl { get; set; }
        public string ResponseRemark { get; set; }
        public Nullable<int> ResponseTime { get; set; }
        public Nullable<int> ProcessedCount { get; set; }
        public string ErrorMessage { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public int OrderID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Order Order { get; set; }
    }
}
