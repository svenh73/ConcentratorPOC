using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingSetting
    {
        public MasterGroupMappingSetting()
        {
            this.MasterGroupMappingSettingOptions = new List<MasterGroupMappingSettingOption>();
            this.MasterGroupMappingSettingTemplates = new List<MasterGroupMappingSettingTemplate>();
            this.MasterGroupMappingSettingValues = new List<MasterGroupMappingSettingValue>();
        }

        public int MasterGroupMappingSettingID { get; set; }
        public string Group { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MasterGroupMappingSettingOption> MasterGroupMappingSettingOptions { get; set; }
        public virtual ICollection<MasterGroupMappingSettingTemplate> MasterGroupMappingSettingTemplates { get; set; }
        public virtual ICollection<MasterGroupMappingSettingValue> MasterGroupMappingSettingValues { get; set; }
    }
}
