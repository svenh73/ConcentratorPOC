using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorPublicationRule
    {
        public ConnectorPublicationRule()
        {
            this.MasterGroupMappingProducts = new List<MasterGroupMappingProduct>();
        }

        public int ConnectorPublicationRuleID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> PublicationType { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<bool> PublishOnlyStock { get; set; }
        public int PublicationIndex { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> ConnectorRelationID { get; set; }
        public Nullable<decimal> FromPrice { get; set; }
        public Nullable<decimal> ToPrice { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public bool IsActive { get; set; }
        public bool EnabledByDefault { get; set; }
        public Nullable<int> MasterGroupMappingID { get; set; }
        public bool OnlyApprovedProducts { get; set; }
        public Nullable<int> AttributeID { get; set; }
        public string AttributeValue { get; set; }
        public virtual AssortmentStatus AssortmentStatus { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ConnectorRelation ConnectorRelation { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductAttributeMetaData ProductAttributeMetaData { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<MasterGroupMappingProduct> MasterGroupMappingProducts { get; set; }
    }
}
