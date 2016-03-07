using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrator.Entities
{
    public partial class ProductRelation
    {
      [Column(Order = 0), Key, ForeignKey("Product")]
      public int ProductId { get; set; }
      [Column(Order = 1), Key, ForeignKey("ProductRelationType")]
      public int RelatedProductId { get; set; }
      public int RelatedProductTypeId { get; set; }
      public virtual Product Product { get; set; }
      public virtual ProductRelationType ProductRelationType { get; set; }
    }
}
