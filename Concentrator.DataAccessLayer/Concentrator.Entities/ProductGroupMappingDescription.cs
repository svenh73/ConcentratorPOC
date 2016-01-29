using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupMappingDescription
    {
        public int ProductGroupMappingID { get; set; }
        public int LanguageID { get; set; }
        public string Description { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
    }
}
