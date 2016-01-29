using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingDescription
    {
        public int MasterGroupMappingID { get; set; }
        public int LanguageID { get; set; }
        public string Description { get; set; }
        public virtual Language Language { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
    }
}
