using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentProductGroup
    {
        public int ContentProductGroupID { get; set; }
        public int ConnectorID { get; set; }
        public int ProductID { get; set; }
        public int ProductGroupMappingID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public bool IsCustom { get; set; }
        public bool Exists { get; set; }
        public bool IsExported { get; set; }
        public Nullable<int> MasterGroupMappingID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
    }
}
