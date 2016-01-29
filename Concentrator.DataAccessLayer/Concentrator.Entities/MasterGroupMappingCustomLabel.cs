using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingCustomLabel
    {
        public int MasterGroupMappingCustomLabelID { get; set; }
        public int MasterGroupMappingID { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public string CustomLabel { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Language Language { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
    }
}
