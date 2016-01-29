using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Content
    {
        public int ProductID { get; set; }
        public int ConnectorID { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string LineType { get; set; }
        public string LedgerClass { get; set; }
        public string ProductDesk { get; set; }
        public Nullable<bool> ExtendedCatalog { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<int> ProductContentID { get; set; }
        public Nullable<int> ConnectorPublicationRuleID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ContentProduct ContentProduct { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
