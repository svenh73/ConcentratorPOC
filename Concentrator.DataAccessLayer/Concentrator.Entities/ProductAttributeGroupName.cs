using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeGroupName
    {
        public string Name { get; set; }
        public int ProductAttributeGroupID { get; set; }
        public int LanguageID { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductAttributeGroupMetaData ProductAttributeGroupMetaData { get; set; }
    }
}
