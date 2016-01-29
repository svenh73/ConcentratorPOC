using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompetitorMapping
    {
        public ProductCompetitorMapping()
        {
            this.ProductCompetitorPrices = new List<ProductCompetitorPrice>();
        }

        public int ProductCompetitorMappingID { get; set; }
        public string Competitor { get; set; }
        public int ProductCompareSourceID { get; set; }
        public Nullable<int> ProductCompetitorID { get; set; }
        public bool IncludeShippingCost { get; set; }
        public bool InTaxPrice { get; set; }
        public virtual ProductCompareSource ProductCompareSource { get; set; }
        public virtual ProductCompetitor ProductCompetitor { get; set; }
        public virtual ICollection<ProductCompetitorPrice> ProductCompetitorPrices { get; set; }
    }
}
