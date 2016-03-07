using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class AttributeOption
    {
        public AttributeOption()
        {
            this.AttributeOptionTranslations = new List<AttributeOptionTranslation>();
        }
        [Key]
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string Name { get; set; }
        public bool Default { get; set; }
        public Nullable<int> Index { get; set; }
        public bool Active { get; set; }
        public virtual Attribute Attribute { get; set; }
        public virtual ICollection<AttributeOptionTranslation> AttributeOptionTranslations { get; set; }
    }
}
