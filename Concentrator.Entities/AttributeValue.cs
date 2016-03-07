using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class AttributeValue
    {
      [Key]
      public int Id { get; set; }
      public int LanguageId { get; set; }
      public Nullable<int> VendorId { get; set; }
      public int AttributeId { get; set; }
      public int ProductId { get; set; }
      public string Value { get; set; }
      public virtual Attribute Attribute { get; set; }
      public virtual Product Product { get; set; }
      public virtual Language Language { get; set; }
    }
}
