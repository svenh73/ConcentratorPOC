using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeValue
    {
        public int AttributeValueID { get; set; }
        public int AttributeID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Value { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Language Language { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
