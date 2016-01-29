using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompetitorPrice
    {
        public ProductCompetitorPrice()
        {
            this.ProductCompetitorLedgers = new List<ProductCompetitorLedger>();
        }

        public int ProductCompetitorPriceID { get; set; }
        public int ProductCompetitorMappingID { get; set; }
        public Nullable<int> CompareProductID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public decimal Price { get; set; }
        public string Stock { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public System.DateTime LastImport { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductCompare ProductCompare { get; set; }
        public virtual ICollection<ProductCompetitorLedger> ProductCompetitorLedgers { get; set; }
        public virtual ProductCompetitorMapping ProductCompetitorMapping { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
