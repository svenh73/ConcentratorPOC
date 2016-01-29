using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorStock
    {
        public int ProductID { get; set; }
        public int VendorID { get; set; }
        public int QuantityOnHand { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDate { get; set; }
        public Nullable<int> QuantityToReceive { get; set; }
        public int VendorStockTypeID { get; set; }
        public string StockStatus { get; set; }
        public Nullable<decimal> UnitCost { get; set; }
        public Nullable<int> ConcentratorStatusID { get; set; }
        public string VendorStatus { get; set; }
        public virtual AssortmentStatus AssortmentStatus { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual VendorStockType VendorStockType { get; set; }
    }
}
