using System;
using System.Collections.Generic;
using Concentrator.Entities;

namespace Concentrator.Entities
{
    public partial class Connector
    {
        public Connector()
        {
            this.AdditionalOrderProducts = new List<AdditionalOrderProduct>();
            this.AttributeMatchStores = new List<AttributeMatchStore>();
            this.Connector1 = new List<Connector>();
            this.ProductAttributeValueGroups = new List<ProductAttributeValueGroup>();
            this.ExcludeProducts = new List<ExcludeProduct>();
            this.ConnectorLanguages = new List<ConnectorLanguage>();
            this.ConnectorPaymentProviders = new List<ConnectorPaymentProvider>();
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ConnectorRelations = new List<ConnectorRelation>();
            this.ConnectorRuleValues = new List<ConnectorRuleValue>();
            this.ConnectorSchedules = new List<ConnectorSchedule>();
            this.ConnectorSettings = new List<ConnectorSetting>();
            this.Contents = new List<Content>();
            this.ContentPrices = new List<ContentPrice>();
            this.ContentProducts = new List<ContentProduct>();
            this.ContentProductGroups = new List<ContentProductGroup>();
            this.ContentStocks = new List<ContentStock>();
            this.ContentVendorSettings = new List<ContentVendorSetting>();
            this.CrossLedgerclasses = new List<CrossLedgerclass>();
            this.EdiOrders = new List<EdiOrder>();
            this.EdiOrderListeners = new List<EdiOrderListener>();
            this.EdiOrderPosts = new List<EdiOrderPost>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
            this.MasterGroupMappingCustomLabels = new List<MasterGroupMappingCustomLabel>();
            this.MasterGroupMappingMedias = new List<MasterGroupMappingMedia>();
            this.MissingContents = new List<MissingContent>();
            this.Orders = new List<Order>();
            this.Outbounds = new List<Outbound>();
            this.ProductAttributeValueConnectorValueGroups = new List<ProductAttributeValueConnectorValueGroup>();
            this.ProductAttributeValueLabels = new List<ProductAttributeValueLabel>();
            this.PreferredConnectorVendors = new List<PreferredConnectorVendor>();
            this.PriceSets = new List<PriceSet>();
            this.ProductAttributeGroupMetaDatas = new List<ProductAttributeGroupMetaData>();
            this.ProductCompares = new List<ProductCompare>();
            this.ProductGroupConnectorVendors = new List<ProductGroupConnectorVendor>();
            this.ProductGroupMappings = new List<ProductGroupMapping>();
            this.ProductGroupMappingCustomLabels = new List<ProductGroupMappingCustomLabel>();
            this.ProductGroupPublishes = new List<ProductGroupPublish>();
            this.Users = new List<User>();
            this.MasterGroupMappings1 = new List<MasterGroupMapping>();
        }

        public int ConnectorID { get; set; }
        public string Name { get; set; }
        public int ConnectorType { get; set; }
        public Nullable<int> ConnectorSystemID { get; set; }
        public bool ConcatenateBrandName { get; set; }
        public bool ObsoleteProducts { get; set; }
        public bool ZipCodes { get; set; }
        public bool Selectors { get; set; }
        public bool OverrideDescriptions { get; set; }
        public Nullable<int> BSKIdentifier { get; set; }
        public string BackendEanIdentifier { get; set; }
        public bool UseConcentratorProductID { get; set; }
        public string Connection { get; set; }
        public bool ImportCommercialText { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> AdministrativeVendorID { get; set; }
        public string OutboundUrl { get; set; }
        public Nullable<int> ParentConnectorID { get; set; }
        public string DefaultImage { get; set; }
        public Nullable<int> ConnectorSystemType { get; set; }
        public Nullable<bool> IgnoreMissingImage { get; set; }
        public bool IgnoreMissingConcentratorDescription { get; set; }
        public int OrganizationID { get; set; }
        public virtual ICollection<AdditionalOrderProduct> AdditionalOrderProducts { get; set; }
        public virtual ICollection<AttributeMatchStore> AttributeMatchStores { get; set; }
        public virtual ICollection<Connector> Connector1 { get; set; }
        public virtual Connector Connector2 { get; set; }
        public virtual ICollection<ProductAttributeValueGroup> ProductAttributeValueGroups { get; set; }
        public virtual ConnectorSystem ConnectorSystem { get; set; }
        public virtual ICollection<ExcludeProduct> ExcludeProducts { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ConnectorLanguage> ConnectorLanguages { get; set; }
        public virtual ICollection<ConnectorPaymentProvider> ConnectorPaymentProviders { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ConnectorRelation> ConnectorRelations { get; set; }
        public virtual ICollection<ConnectorRuleValue> ConnectorRuleValues { get; set; }
        public virtual ICollection<ConnectorSchedule> ConnectorSchedules { get; set; }
        public virtual ICollection<ConnectorSetting> ConnectorSettings { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<ContentProduct> ContentProducts { get; set; }
        public virtual ICollection<ContentProductGroup> ContentProductGroups { get; set; }
        public virtual ICollection<ContentStock> ContentStocks { get; set; }
        public virtual ICollection<ContentVendorSetting> ContentVendorSettings { get; set; }
        public virtual ICollection<CrossLedgerclass> CrossLedgerclasses { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders { get; set; }
        public virtual ICollection<EdiOrderListener> EdiOrderListeners { get; set; }
        public virtual ICollection<EdiOrderPost> EdiOrderPosts { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
        public virtual ICollection<MasterGroupMappingCustomLabel> MasterGroupMappingCustomLabels { get; set; }
        public virtual ICollection<MasterGroupMappingMedia> MasterGroupMappingMedias { get; set; }
        public virtual ICollection<MissingContent> MissingContents { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Outbound> Outbounds { get; set; }
        public virtual ICollection<ProductAttributeValueConnectorValueGroup> ProductAttributeValueConnectorValueGroups { get; set; }
        public virtual ICollection<ProductAttributeValueLabel> ProductAttributeValueLabels { get; set; }
        public virtual ICollection<PreferredConnectorVendor> PreferredConnectorVendors { get; set; }
        public virtual ICollection<PriceSet> PriceSets { get; set; }
        public virtual ICollection<ProductAttributeGroupMetaData> ProductAttributeGroupMetaDatas { get; set; }
        public virtual ICollection<ProductCompare> ProductCompares { get; set; }
        public virtual ICollection<ProductGroupConnectorVendor> ProductGroupConnectorVendors { get; set; }
        public virtual ICollection<ProductGroupMapping> ProductGroupMappings { get; set; }
        public virtual ICollection<ProductGroupMappingCustomLabel> ProductGroupMappingCustomLabels { get; set; }
        public virtual ICollection<ProductGroupPublish> ProductGroupPublishes { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings1 { get; set; }
    }
}
