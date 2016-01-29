using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MagentoProductGroupSetting
    {
        public int MagentoProductGroupSettingID { get; set; }
        public Nullable<int> ProductGroupmappingID { get; set; }
        public Nullable<bool> ShowInMenu { get; set; }
        public Nullable<bool> DisabledMenu { get; set; }
        public Nullable<bool> IsAnchor { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> MasterGroupMappingID { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
    }
}
