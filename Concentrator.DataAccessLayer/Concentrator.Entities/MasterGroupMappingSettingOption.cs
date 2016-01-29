using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingSettingOption
    {
        public int MasterGroupMappingSettingID { get; set; }
        public int OptionID { get; set; }
        public string Value { get; set; }
        public virtual MasterGroupMappingSetting MasterGroupMappingSetting { get; set; }
    }
}
