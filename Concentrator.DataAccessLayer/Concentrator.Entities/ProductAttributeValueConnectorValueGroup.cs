using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeValueConnectorValueGroup
    {
        public string Value { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public int AttributeID { get; set; }
        public int AttributeValueGroupID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
        public virtual ProductAttributeValueGroup ProductAttributeValueGroup { get; set; }
    }
}
