using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingSettingTemplate
    {
        public int MasterGroupMappingSettingTemplateID { get; set; }
        public int MasterGroupMappingSettingID { get; set; }
        public int LanguageID { get; set; }
        public string DefaultValue { get; set; }
        public virtual MasterGroupMappingSetting MasterGroupMappingSetting { get; set; }
    }
}
