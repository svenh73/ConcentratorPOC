using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingRelatedAttribute
    {
        public MasterGroupMappingRelatedAttribute()
        {
            this.MasterGroupMappingRelatedAttribute1 = new List<MasterGroupMappingRelatedAttribute>();
        }

        public int RelatedAttributeID { get; set; }
        public int MasterGroupMappingID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int AttributeID { get; set; }
        public string AttributeValue { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual ICollection<MasterGroupMappingRelatedAttribute> MasterGroupMappingRelatedAttribute1 { get; set; }
        public virtual MasterGroupMappingRelatedAttribute MasterGroupMappingRelatedAttribute2 { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
