using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompetitor
    {
        public ProductCompetitor()
        {
            this.ProductCompetitorMappings = new List<ProductCompetitorMapping>();
        }

        public int ProductCompetitorID { get; set; }
        public string Name { get; set; }
        public int Reliability { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public decimal ShippingCostPerOrder { get; set; }
        public Nullable<decimal> ShippingCost { get; set; }
        public virtual ICollection<ProductCompetitorMapping> ProductCompetitorMappings { get; set; }
    }
}
