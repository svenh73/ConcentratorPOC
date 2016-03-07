using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Currrency
    {
        public Currrency()
        {
            this.Prices = new List<Price>();
        }
      [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
