using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class StockType
    {
        public StockType()
        {
            this.Stocks = new List<Stock>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
