using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class ChannelProduct
    {
        public ChannelProduct()
        {
            this.Prices = new List<Price>();
            this.Stocks = new List<Stock>();
        }
      [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ChannelId { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
