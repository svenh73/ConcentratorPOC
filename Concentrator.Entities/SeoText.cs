using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class SeoText
    {
        public int SeoTextID { get; set; }
        public Nullable<int> ProductGroupMappingID { get; set; }
        public string Description { get; set; }
        public int DescriptionType { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> MasterGroupMappingID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public virtual Language Language { get; set; }
    }
}
