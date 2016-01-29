using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class RefundQueueHistory
    {
        public int OrderID { get; set; }
        public int OrderResponseID { get; set; }
        public System.DateTime CreationTime { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime ProcessedTime { get; set; }
    }
}
