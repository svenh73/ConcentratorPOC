using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class orderledgertempatdatcol
    {
        public int OrderLedgerID { get; set; }
        public int OrderLineID { get; set; }
        public int Status { get; set; }
        public System.DateTime LedgerDate { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}
