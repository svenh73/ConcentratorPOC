using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeGroupMetaData
    {
        public ProductAttributeGroupMetaData()
        {
            this.ProductAttributeMetaDatas = new List<ProductAttributeMetaData>();
            this.ProductAttributeGroupNames = new List<ProductAttributeGroupName>();
        }

        public int ProductAttributeGroupID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public int Index { get; set; }
        public string GroupCode { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> SourceGroupID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ProductAttributeMetaData> ProductAttributeMetaDatas { get; set; }
        public virtual ICollection<ProductAttributeGroupName> ProductAttributeGroupNames { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
