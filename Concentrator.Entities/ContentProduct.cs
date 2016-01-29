using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentProduct
    {
        public ContentProduct()
        {
            this.Contents = new List<Content>();
            this.ContentPublicationRules = new List<ContentPublicationRule>();
        }

        public int ProductContentID { get; set; }
        public int ConnectorID { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public int ProductContentIndex { get; set; }
        public bool IsAssortment { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ContentPublicationRule> ContentPublicationRules { get; set; }
    }
}
