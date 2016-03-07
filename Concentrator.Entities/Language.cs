using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Language
    {
        public Language()
        {
            this.Attributes = new List<Attribute>();
            this.AttributeOptionTranslations = new List<AttributeOptionTranslation>();
            this.AttributeTranslations = new List<AttributeTranslation>();
            this.AttributeValues = new List<AttributeValue>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Default { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<AttributeOptionTranslation> AttributeOptionTranslations { get; set; }
        public virtual ICollection<AttributeTranslation> AttributeTranslations { get; set; }
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
}
