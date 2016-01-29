using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeValueGroupName
    {
        public int AttributeValueGroupID { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductAttributeValueGroup ProductAttributeValueGroup { get; set; }
    }
}
