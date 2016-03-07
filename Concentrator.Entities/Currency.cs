using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Currency
    {
      [Key]  
      public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
