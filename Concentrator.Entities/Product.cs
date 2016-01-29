using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
  public partial class Product
  {
    public Product()
    {
      this.ConnectorPublications = new List<ConnectorPublication>();
      this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
      this.Contents = new List<Content>();
      this.ContentLedgers = new List<ContentLedger>();
      this.ContentPrices = new List<ContentPrice>();
      this.ContentProducts = new List<ContentProduct>();
      this.ContentProductGroups = new List<ContentProductGroup>();
      this.ContentProductMatches = new List<ContentProductMatch>();
      this.ContentVendorSettings = new List<ContentVendorSetting>();
      this.FaqProducts = new List<FaqProduct>();
      this.MasterGroupMappingProducts = new List<MasterGroupMappingProduct>();
      this.MasterGroupMappingProductVendors = new List<MasterGroupMappingProductVendor>();
      this.MissingContents = new List<MissingContent>();
      this.OrderLines = new List<OrderLine>();
      this.OrderResponseLines = new List<OrderResponseLine>();
      this.ProductBarcodes = new List<ProductBarcode>();
      this.ProductDescriptions = new List<ProductDescription>();
      this.ProductPriceSets = new List<ProductPriceSet>();
      this.ProductAttributeValues = new List<ProductAttributeValue>();
      this.ProductCompetitorPrices = new List<ProductCompetitorPrice>();
      this.ProductImages = new List<ProductImage>();
      this.ProductMedias = new List<ProductMedia>();
      this.ProductReviews = new List<ProductReview>();
      this.RelatedProducts = new List<RelatedProduct>();
      this.RelatedProducts1 = new List<RelatedProduct>();
      this.SlurpQueues = new List<SlurpQueue>();
      this.SlurpSchedules = new List<SlurpSchedule>();
      this.VendorAssortments = new List<VendorAssortment>();
      this.VendorFreeGoods = new List<VendorFreeGood>();
      this.VendorPriceRules = new List<VendorPriceRule>();
      this.VendorProductMatches = new List<VendorProductMatch>();
      this.VendorProductMatches1 = new List<VendorProductMatch>();
      this.VendorStocks = new List<VendorStock>();
      this.Product1 = new List<Product>();
      this.ProductAttributeMetaDatas = new List<ProductAttributeMetaData>();
    }

    public int ProductID { get; set; }
    public string VendorItemNumber { get; set; }
    public int BrandID { get; set; }
    public int SourceVendorID { get; set; }
    public int CreatedBy { get; set; }
    public System.DateTime CreationTime { get; set; }
    public Nullable<System.DateTime> LastModificationTime { get; set; }
    public Nullable<int> LastModifiedBy { get; set; }
    public bool IsConfigurable { get; set; }
    public Nullable<bool> IsNonAssortmentItem { get; set; }
    public Nullable<int> ParentProductID { get; set; }
    public bool Visible { get; set; }
    public bool IsBlocked { get; set; }
    public virtual Brand Brand { get; set; }
    public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
    public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
    public virtual ICollection<Content> Contents { get; set; }
    public virtual ICollection<ContentLedger> ContentLedgers { get; set; }
    public virtual ICollection<ContentPrice> ContentPrices { get; set; }
    public virtual ICollection<ContentProduct> ContentProducts { get; set; }
    public virtual ICollection<ContentProductGroup> ContentProductGroups { get; set; }
    public virtual ICollection<ContentProductMatch> ContentProductMatches { get; set; }
    public virtual ICollection<ContentVendorSetting> ContentVendorSettings { get; set; }
    public virtual ICollection<FaqProduct> FaqProducts { get; set; }
    public virtual ICollection<MasterGroupMappingProduct> MasterGroupMappingProducts { get; set; }
    public virtual ICollection<MasterGroupMappingProductVendor> MasterGroupMappingProductVendors { get; set; }
    public virtual ICollection<MissingContent> MissingContents { get; set; }
    public virtual ICollection<OrderLine> OrderLines { get; set; }
    public virtual ICollection<OrderResponseLine> OrderResponseLines { get; set; }
    public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; }
    public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
    public virtual ICollection<ProductPriceSet> ProductPriceSets { get; set; }
    public virtual User User { get; set; }
    public virtual User User1 { get; set; }
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    public virtual ICollection<ProductCompetitorPrice> ProductCompetitorPrices { get; set; }
    public virtual ICollection<ProductImage> ProductImages { get; set; }
    public virtual ProductMatch ProductMatch { get; set; }
    public virtual ICollection<ProductMedia> ProductMedias { get; set; }
    public virtual ICollection<ProductReview> ProductReviews { get; set; }
    public virtual ICollection<RelatedProduct> RelatedProducts { get; set; }
    public virtual ICollection<RelatedProduct> RelatedProducts1 { get; set; }
    public virtual ICollection<SlurpQueue> SlurpQueues { get; set; }
    public virtual ICollection<SlurpSchedule> SlurpSchedules { get; set; }
    public virtual ICollection<VendorAssortment> VendorAssortments { get; set; }
    public virtual ICollection<VendorFreeGood> VendorFreeGoods { get; set; }
    public virtual ICollection<VendorPriceRule> VendorPriceRules { get; set; }
    public virtual ICollection<VendorProductMatch> VendorProductMatches { get; set; }
    public virtual ICollection<VendorProductMatch> VendorProductMatches1 { get; set; }
    public virtual ICollection<VendorStock> VendorStocks { get; set; }
    public virtual ICollection<Product> Product1 { get; set; }
    public virtual Product Product2 { get; set; }
    public virtual ICollection<ProductAttributeMetaData> ProductAttributeMetaDatas { get; set; }
  }
}
