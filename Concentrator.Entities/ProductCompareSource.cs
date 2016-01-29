using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompareSource
    {
        public ProductCompareSource()
        {
            this.ContentPrices = new List<ContentPrice>();
            this.ProductCompares = new List<ProductCompare>();
            this.ProductCompareSource1 = new List<ProductCompareSource>();
            this.ProductCompetitorMappings = new List<ProductCompetitorMapping>();
            this.SlurpQueues = new List<SlurpQueue>();
            this.SlurpSchedules = new List<SlurpSchedule>();
        }

        public int ProductCompareSourceID { get; set; }
        public string Source { get; set; }
        public Nullable<int> ProductCompareSourceParentID { get; set; }
        public string ProductCompareSourceType { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
        public virtual ICollection<ProductCompare> ProductCompares { get; set; }
        public virtual ICollection<ProductCompareSource> ProductCompareSource1 { get; set; }
        public virtual ProductCompareSource ProductCompareSource2 { get; set; }
        public virtual ICollection<ProductCompetitorMapping> ProductCompetitorMappings { get; set; }
        public virtual ICollection<SlurpQueue> SlurpQueues { get; set; }
        public virtual ICollection<SlurpSchedule> SlurpSchedules { get; set; }
    }
}
