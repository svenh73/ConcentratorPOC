using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            this.Products = new List<Product>();
            this.ProductGroup1 = new List<ProductGroup>();
            this.Attributes = new List<Attribute>();
        }
      [Key]
        public int Id { get; set; }
        public Nullable<int> ProductGroupId { get; set; }
        public Nullable<int> Index { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductGroup> ProductGroup1 { get; set; }
        public virtual ProductGroup ProductGroup2 { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
