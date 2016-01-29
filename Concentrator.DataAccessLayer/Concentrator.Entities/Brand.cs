using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            this.Brand1 = new List<Brand>();
            this.BrandMedias = new List<BrandMedia>();
            this.BrandVendors = new List<BrandVendor>();
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ContentPrices = new List<ContentPrice>();
            this.ContentProducts = new List<ContentProduct>();
            this.ContentVendorSettings = new List<ContentVendorSetting>();
            this.MissingContents = new List<MissingContent>();
            this.Products = new List<Product>();
            this.VendorPriceRules = new List<VendorPriceRule>();
        }

        public int BrandID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentBrandID { get; set; }
        public string Description { get; set; }
        public bool Test2 { get; set; }
        public virtual ICollection<Brand> Brand1 { get; set; }
        public virtual Brand Brand2 { get; set; }
        public virtual ICollection<BrandMedia> BrandMedias { get; set; }
        public virtual ICollection<BrandVendor> BrandVendors { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<ContentProduct> ContentProducts { get; set; }
        public virtual ICollection<ContentVendorSetting> ContentVendorSettings { get; set; }
        public virtual ICollection<MissingContent> MissingContents { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<VendorPriceRule> VendorPriceRules { get; set; }
    }
}
