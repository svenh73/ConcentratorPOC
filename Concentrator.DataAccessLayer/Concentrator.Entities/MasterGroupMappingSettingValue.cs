using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingSettingValue
    {
        public int MasterGroupMappingID { get; set; }
        public int MasterGroupMappingSettingID { get; set; }
        public string Value { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual MasterGroupMappingSetting MasterGroupMappingSetting { get; set; }
    }
}
