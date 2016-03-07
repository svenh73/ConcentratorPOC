using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Stock
    {
        [Key]
      public int Id { get; set; }
        public Nullable<int> VendorProductId { get; set; }
        public int ChannelProductId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime LastModified { get; set; }
        public virtual ChannelProduct ChannelProduct { get; set; }
        public virtual StockType StockType { get; set; }
        public virtual VendorProduct VendorProduct { get; set; }
    }
}
