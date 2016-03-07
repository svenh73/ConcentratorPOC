using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class AttributeTranslation
    {
      [Key]  
      public int Id { get; set; }
      public int AttributeId { get; set; }
      public int LanguageId { get; set; }
      public string Translation { get; set; }
      public virtual Attribute Attribute { get; set; }
      public virtual Language Language { get; set; }
    }
}
