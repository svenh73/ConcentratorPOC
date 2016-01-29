using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductPriceSet
    {
        public int PriceSetID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public virtual PriceSet PriceSet { get; set; }
        public virtual Product Product { get; set; }
    }
}
