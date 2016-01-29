using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class RefundQueue
    {
        public int OrderID { get; set; }
        public int OrderResponseID { get; set; }
        public bool Valid { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreationTime { get; set; }
        public string WebsiteOrderNumber { get; set; }
        public virtual Order Order { get; set; }
        public virtual OrderResponse OrderResponse { get; set; }
    }
}
