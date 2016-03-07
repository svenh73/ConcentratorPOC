using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class AttributeOptionTranslation
    {
        [Key]
        public int Id { get; set; }
        public int AttributeOptionId { get; set; }
        public int LanguageId { get; set; }
        public string Translation { get; set; }
        public virtual AttributeOption AttributeOption { get; set; }
        public virtual Language Language { get; set; }
    }
}
