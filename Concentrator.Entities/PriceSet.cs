using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PriceSet
    {
        public PriceSet()
        {
            this.ProductPriceSets = new List<ProductPriceSet>();
        }

        public int PriceSetID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsCatalog { get; set; }
        public int ConnectorID { get; set; }
        public Nullable<decimal> DiscountPercentage { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ProductPriceSet> ProductPriceSets { get; set; }
    }
}
