using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductAttributeMetaData
    {
        public ProductAttributeMetaData()
        {
            this.AttributeMatchStores = new List<AttributeMatchStore>();
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ContentPrices = new List<ContentPrice>();
            this.MasterGroupMappingRelatedAttributes = new List<MasterGroupMappingRelatedAttribute>();
            this.ProductAttributeDescriptions = new List<ProductAttributeDescription>();
            this.ProductAttributeValueConnectorValueGroups = new List<ProductAttributeValueConnectorValueGroup>();
            this.ProductAttributeValueLabels = new List<ProductAttributeValueLabel>();
            this.ProductAttributeNames = new List<ProductAttributeName>();
            this.ProductAttributeOptions = new List<ProductAttributeOption>();
            this.ProductAttributeValues = new List<ProductAttributeValue>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
            this.Products = new List<Product>();
        }

        public int AttributeID { get; set; }
        public string AttributeCode { get; set; }
        public int ProductAttributeGroupID { get; set; }
        public string FormatString { get; set; }
        public string DataType { get; set; }
        public Nullable<int> Index { get; set; }
        public bool IsVisible { get; set; }
        public bool NeedsUpdate { get; set; }
        public Nullable<int> VendorID { get; set; }
        public bool IsSearchable { get; set; }
        public string Sign { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public string AttributePath { get; set; }
        public bool Mandatory { get; set; }
        public string DefaultValue { get; set; }
        public bool IsConfigurable { get; set; }
        public Nullable<int> ConfigurablePosition { get; set; }
        public Nullable<bool> HasOption { get; set; }
        public bool IsSlider { get; set; }
        public string FrontendType { get; set; }
        public virtual ICollection<AttributeMatchStore> AttributeMatchStores { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<MasterGroupMappingRelatedAttribute> MasterGroupMappingRelatedAttributes { get; set; }
        public virtual ICollection<ProductAttributeDescription> ProductAttributeDescriptions { get; set; }
        public virtual ProductAttributeGroupMetaData ProductAttributeGroupMetaData { get; set; }
        public virtual ICollection<ProductAttributeValueConnectorValueGroup> ProductAttributeValueConnectorValueGroups { get; set; }
        public virtual ICollection<ProductAttributeValueLabel> ProductAttributeValueLabels { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ProductAttributeName> ProductAttributeNames { get; set; }
        public virtual ICollection<ProductAttributeOption> ProductAttributeOptions { get; set; }
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
