using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class CrossLedgerclass
    {
        public int ConnectorID { get; set; }
        public string LedgerclassCode { get; set; }
        public string CrossLedgerclassCode { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
