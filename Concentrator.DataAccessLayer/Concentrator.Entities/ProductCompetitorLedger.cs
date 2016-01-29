using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductCompetitorLedger
    {
        public int ProductCompetitorLedgerID { get; set; }
        public int ProductCompetitorPriceID { get; set; }
        public string Stock { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public virtual ProductCompetitorPrice ProductCompetitorPrice { get; set; }
    }
}
