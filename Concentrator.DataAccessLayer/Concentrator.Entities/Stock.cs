using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Stock
    {
        public int ProductID { get; set; }
        public Nullable<int> QuantityOnHand { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDate { get; set; }
        public Nullable<int> QuantityToReceive { get; set; }
    }
}
