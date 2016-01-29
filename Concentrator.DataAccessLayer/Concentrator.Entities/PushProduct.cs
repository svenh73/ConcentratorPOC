using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PushProduct
    {
        public int PushProductID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string CustomItemNumber { get; set; }
        public int VendorID { get; set; }
        public int ConnectorID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public bool Processed { get; set; }
        public Nullable<System.DateTime> LastPushDate { get; set; }
    }
}
