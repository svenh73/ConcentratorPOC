using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Attribute
    {
        public Attribute()
        {
            this.AttributeOptions = new List<AttributeOption>();
            this.AttributeTranslations = new List<AttributeTranslation>();
            this.ProductGroups = new List<ProductGroup>();
        }
        [Key]
        public int Id { get; set; }
        public Nullable<int> AttributeTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AttributeOption> AttributeOptions { get; set; }
        public virtual ICollection<AttributeTranslation> AttributeTranslations { get; set; }
        public virtual AttributeValue AttributeValue { get; set; }
        public virtual Language Language { get; set; }
        public virtual AttributeType AttributeType { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
    }
}
