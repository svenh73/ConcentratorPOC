using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeName
    {
        public int AttributeID { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
