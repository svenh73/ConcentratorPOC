using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class ProductRelationType
    {
        public ProductRelationType()
        {
            this.ProductRelations = new List<ProductRelation>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductRelation> ProductRelations { get; set; }
    }
}
