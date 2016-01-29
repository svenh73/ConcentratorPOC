using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingLabel
    {
        public int MasterGroupMappingLabelID { get; set; }
        public int MasterGroupMappingID { get; set; }
        public string Label { get; set; }
        public Nullable<bool> SearchEngine { get; set; }
        public int LanguageID { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
    }
}
