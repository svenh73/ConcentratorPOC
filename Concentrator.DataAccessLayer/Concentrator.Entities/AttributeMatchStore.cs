using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class AttributeMatchStore
    {
        public int AttributeStoreID { get; set; }
        public int AttributeID { get; set; }
        public int ConnectorID { get; set; }
        public string StoreName { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
    }
}
