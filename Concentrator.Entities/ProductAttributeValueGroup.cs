using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeValueGroup
    {
        public ProductAttributeValueGroup()
        {
            this.ProductAttributeValueConnectorValueGroups = new List<ProductAttributeValueConnectorValueGroup>();
            this.ProductAttributeValueGroupNames = new List<ProductAttributeValueGroupName>();
        }

        public int AttributeValueGroupID { get; set; }
        public int Score { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ProductAttributeValueConnectorValueGroup> ProductAttributeValueConnectorValueGroups { get; set; }
        public virtual ICollection<ProductAttributeValueGroupName> ProductAttributeValueGroupNames { get; set; }
    }
}
