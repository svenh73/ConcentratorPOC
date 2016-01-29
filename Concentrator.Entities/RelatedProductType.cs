using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class RelatedProductType
    {
        public RelatedProductType()
        {
            this.RelatedProducts = new List<RelatedProduct>();
        }

        public int RelatedProductTypeID { get; set; }
        public string Type { get; set; }
        public bool IsConfigured { get; set; }
        public Nullable<int> TypeMapsToMagentoTypeID { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProducts { get; set; }
    }
}
