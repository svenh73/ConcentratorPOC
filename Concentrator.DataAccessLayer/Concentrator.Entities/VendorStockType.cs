using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorStockType
    {
        public VendorStockType()
        {
            this.ContentStocks = new List<ContentStock>();
            this.VendorStocks = new List<VendorStock>();
        }

        public int VendorStockTypeID { get; set; }
        public string StockType { get; set; }
        public virtual ICollection<ContentStock> ContentStocks { get; set; }
        public virtual ICollection<VendorStock> VendorStocks { get; set; }
    }
}
