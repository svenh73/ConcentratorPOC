using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeOption
    {
        public int OptionID { get; set; }
        public int AttributeID { get; set; }
        public string AttributeOption { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
