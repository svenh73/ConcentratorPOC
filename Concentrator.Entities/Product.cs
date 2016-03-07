using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Product
    {
        public Product()
        {
            this.AttributeValues = new List<AttributeValue>();
            this.Barcodes = new List<Barcode>();
            this.ChannelProducts = new List<ChannelProduct>();
            this.Product1 = new List<Product>();
            this.ProductRelations = new List<ProductRelation>();
            this.VendorProducts = new List<VendorProduct>();
        }
      [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ProductTypeId { get; set; }
        public Nullable<int> ProductGroupId { get; set; }
        public Nullable<int> ParentProductId { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public Nullable<System.DateTime> DateTimeLastModified { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
        public virtual ICollection<Barcode> Barcodes { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<ChannelProduct> ChannelProducts { get; set; }
        public virtual ICollection<Product> Product1 { get; set; }
        public virtual Product Product2 { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<ProductRelation> ProductRelations { get; set; }
        public virtual ICollection<VendorProduct> VendorProducts { get; set; }
    }
}
