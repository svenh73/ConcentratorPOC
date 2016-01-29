using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupPublish
    {
        public int ProductGroupID { get; set; }
        public bool Published { get; set; }
        public int ConnectorID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
