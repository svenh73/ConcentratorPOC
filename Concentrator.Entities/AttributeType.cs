using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class AttributeType
    {
        public AttributeType()
        {
            this.Attributes = new List<Attribute>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
