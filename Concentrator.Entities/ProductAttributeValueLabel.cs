using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeValueLabel
    {
        public string Value { get; set; }
        public int AttributeID { get; set; }
        public int LanguageID { get; set; }
        public string Label { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public int Id { get; set; }
        public int OrganizationID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Language Language { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
