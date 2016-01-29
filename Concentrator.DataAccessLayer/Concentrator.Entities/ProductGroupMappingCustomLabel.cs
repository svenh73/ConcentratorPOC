using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupMappingCustomLabel
    {
        public int ProductGroupMappingID { get; set; }
        public int LanguageID { get; set; }
        public string CustomLabel { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
    }
}
