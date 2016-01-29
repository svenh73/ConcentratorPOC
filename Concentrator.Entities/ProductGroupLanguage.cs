using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupLanguage
    {
        public int ProductGroupID { get; set; }
        public int LanguageID { get; set; }
        public string Name { get; set; }
        public virtual Language Language { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
