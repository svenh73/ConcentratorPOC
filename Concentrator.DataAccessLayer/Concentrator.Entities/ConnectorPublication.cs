using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorPublication
    {
        public int ConnectorPublicationID { get; set; }
        public int ConnectorID { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<bool> Publish { get; set; }
        public Nullable<bool> PublishOnlyStock { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public int ProductContentIndex { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> AttributeID { get; set; }
        public string AttributeValue { get; set; }
        public virtual AssortmentStatu AssortmentStatu { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
