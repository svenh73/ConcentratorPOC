using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderLedger
    {
        public int EdiOrderLedgerID { get; set; }
        public int EdiOrderLineID { get; set; }
        public int Status { get; set; }
        public System.DateTime LedgerDate { get; set; }
        public virtual EdiOrderLine EdiOrderLine { get; set; }
    }
}
