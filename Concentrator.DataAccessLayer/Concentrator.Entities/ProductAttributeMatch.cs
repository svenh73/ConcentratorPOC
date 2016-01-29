using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeMatch
    {
        public int ProductAttributeMatchID { get; set; }
        public int ProductAttributeGroupID { get; set; }
        public Nullable<int> AttributeID { get; set; }
        public int CorrespondingProductAttributeGroupID { get; set; }
        public Nullable<int> CorrespondingAttributeID { get; set; }
        public Nullable<bool> IsMatched { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> ConnectorID { get; set; }
    }
}
