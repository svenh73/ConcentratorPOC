using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorStockLedger
    {
        public int LedgerID { get; set; }
        public int ProductID { get; set; }
        public int VendorID { get; set; }
        public Nullable<int> VendorStockTypeID { get; set; }
        public Nullable<int> QuantityOnHandOld { get; set; }
        public Nullable<int> QuantityOnHandNew { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDateOld { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDateNew { get; set; }
        public Nullable<int> QuantityToReceiveOld { get; set; }
        public Nullable<int> QuantityToReceiveNew { get; set; }
        public string StockStatusOld { get; set; }
        public string StockStatusNew { get; set; }
        public Nullable<decimal> UnitCostOld { get; set; }
        public Nullable<decimal> UnitCostNew { get; set; }
        public Nullable<int> ConcentratorStatusIDOld { get; set; }
        public Nullable<int> ConcentratorStatusIDNew { get; set; }
        public string VendorStatusOld { get; set; }
        public string VendorStatusNew { get; set; }
        public System.DateTime LedgerDateTime { get; set; }
    }
}
