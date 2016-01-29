using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Vendor
    {
        public Vendor()
        {
            this.AdditionalOrderProducts = new List<AdditionalOrderProduct>();
            this.Connectors = new List<Connector>();
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ConnectorRuleValues = new List<ConnectorRuleValue>();
            this.ContentPrices = new List<ContentPrice>();
            this.ContentProducts = new List<ContentProduct>();
            this.ContentStocks = new List<ContentStock>();
            this.ContentVendorSettings = new List<ContentVendorSetting>();
            this.MasterGroupMappingProductVendors = new List<MasterGroupMappingProductVendor>();
            this.OrderLines = new List<OrderLine>();
            this.OrderResponses = new List<OrderResponse>();
            this.PreferredConnectorVendors = new List<PreferredConnectorVendor>();
            this.ProductAttributeGroupMetaDatas = new List<ProductAttributeGroupMetaData>();
            this.ProductAttributeMetaDatas = new List<ProductAttributeMetaData>();
            this.ProductBarcodes = new List<ProductBarcode>();
            this.ProductDescriptions = new List<ProductDescription>();
            this.ProductGroupConnectorVendors = new List<ProductGroupConnectorVendor>();
            this.ProductGroupContentVendors = new List<ProductGroupContentVendor>();
            this.ProductGroupVendors = new List<ProductGroupVendor>();
            this.ProductImages = new List<ProductImage>();
            this.ProductMedias = new List<ProductMedia>();
            this.RelatedProducts = new List<RelatedProduct>();
            this.UserRoles = new List<UserRole>();
            this.VendorAssortments = new List<VendorAssortment>();
            this.VendorMappings = new List<VendorMapping>();
            this.VendorMappings1 = new List<VendorMapping>();
            this.VendorPriceRules = new List<VendorPriceRule>();
            this.VendorProductMatches = new List<VendorProductMatch>();
            this.VendorProductStatus = new List<VendorProductStatus>();
            this.VendorSettings = new List<VendorSetting>();
            this.VendorStocks = new List<VendorStock>();
            this.VendorTranslations = new List<VendorTranslation>();
            this.VendorTranslations1 = new List<VendorTranslation>();
            this.WehkampMessages = new List<WehkampMessage>();
            this.CommunicatorMessages = new List<CommunicatorMessage>();
        }

        public int VendorID { get; set; }
        public int VendorType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackendVendorCode { get; set; }
        public Nullable<int> ParentVendorID { get; set; }
        public string OrderDispatcherType { get; set; }
        public Nullable<double> CDPrice { get; set; }
        public Nullable<double> DSPrice { get; set; }
        public string PurchaseOrderType { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CutOffTime { get; set; }
        public Nullable<int> DeliveryHours { get; set; }
        public int OrganizationID { get; set; }
        public virtual ICollection<AdditionalOrderProduct> AdditionalOrderProducts { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ConnectorRuleValue> ConnectorRuleValues { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<ContentProduct> ContentProducts { get; set; }
        public virtual ICollection<ContentStock> ContentStocks { get; set; }
        public virtual ICollection<ContentVendorSetting> ContentVendorSettings { get; set; }
        public virtual ICollection<MasterGroupMappingProductVendor> MasterGroupMappingProductVendors { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<OrderResponse> OrderResponses { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<PreferredConnectorVendor> PreferredConnectorVendors { get; set; }
        public virtual ICollection<ProductAttributeGroupMetaData> ProductAttributeGroupMetaDatas { get; set; }
        public virtual ICollection<ProductAttributeMetaData> ProductAttributeMetaDatas { get; set; }
        public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; }
        public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
        public virtual ICollection<ProductGroupConnectorVendor> ProductGroupConnectorVendors { get; set; }
        public virtual ICollection<ProductGroupContentVendor> ProductGroupContentVendors { get; set; }
        public virtual ICollection<ProductGroupVendor> ProductGroupVendors { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductMedia> ProductMedias { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProducts { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<VendorAssortment> VendorAssortments { get; set; }
        public virtual ICollection<VendorMapping> VendorMappings { get; set; }
        public virtual ICollection<VendorMapping> VendorMappings1 { get; set; }
        public virtual ICollection<VendorPriceRule> VendorPriceRules { get; set; }
        public virtual ICollection<VendorProductMatch> VendorProductMatches { get; set; }
        public virtual ICollection<VendorProductStatus> VendorProductStatus { get; set; }
        public virtual ICollection<VendorSetting> VendorSettings { get; set; }
        public virtual ICollection<VendorStock> VendorStocks { get; set; }
        public virtual ICollection<VendorTranslation> VendorTranslations { get; set; }
        public virtual ICollection<VendorTranslation> VendorTranslations1 { get; set; }
        public virtual ICollection<WehkampMessage> WehkampMessages { get; set; }
        public virtual ICollection<CommunicatorMessage> CommunicatorMessages { get; set; }
    }
}
