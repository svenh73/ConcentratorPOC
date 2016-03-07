using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Vendor
    {
      [Key]  
      public int Id { get; set; }
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string VendorType { get; set; }
        public virtual Company Company { get; set; }
        public virtual SettingValue SettingValue { get; set; }
        public virtual VendorProduct VendorProduct { get; set; }
    }
}
