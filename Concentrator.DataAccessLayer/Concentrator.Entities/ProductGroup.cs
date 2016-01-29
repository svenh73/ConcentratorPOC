using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ContentPrices = new List<ContentPrice>();
            this.ContentProducts = new List<ContentProduct>();
            this.ContentVendorSettings = new List<ContentVendorSetting>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
            this.ProductGroupConnectorVendors = new List<ProductGroupConnectorVendor>();
            this.ProductGroupContentVendors = new List<ProductGroupContentVendor>();
            this.ProductGroupLanguages = new List<ProductGroupLanguage>();
            this.ProductGroupMappings = new List<ProductGroupMapping>();
            this.ProductGroupPublishes = new List<ProductGroupPublish>();
            this.ProductGroupVendors = new List<ProductGroupVendor>();
            this.VendorPriceRules = new List<VendorPriceRule>();
        }

        public int ProductGroupID { get; set; }
        public int Score { get; set; }
        public Nullable<bool> Searchable { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<ContentProduct> ContentProducts { get; set; }
        public virtual ICollection<ContentVendorSetting> ContentVendorSettings { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
        public virtual ICollection<ProductGroupConnectorVendor> ProductGroupConnectorVendors { get; set; }
        public virtual ICollection<ProductGroupContentVendor> ProductGroupContentVendors { get; set; }
        public virtual ICollection<ProductGroupLanguage> ProductGroupLanguages { get; set; }
        public virtual ICollection<ProductGroupMapping> ProductGroupMappings { get; set; }
        public virtual ICollection<ProductGroupPublish> ProductGroupPublishes { get; set; }
        public virtual ICollection<ProductGroupVendor> ProductGroupVendors { get; set; }
        public virtual ICollection<VendorPriceRule> VendorPriceRules { get; set; }
    }
}
