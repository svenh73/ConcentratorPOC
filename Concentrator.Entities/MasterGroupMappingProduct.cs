using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingProduct
    {
        public int MasterGroupMappingID { get; set; }
        public int ProductID { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCustom { get; set; }
        public bool IsProductMapped { get; set; }
        public Nullable<int> ConnectorPublicationRuleID { get; set; }
        public virtual ConnectorPublicationRule ConnectorPublicationRule { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual Product Product { get; set; }
    }
}
