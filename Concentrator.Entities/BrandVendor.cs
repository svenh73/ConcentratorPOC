using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class BrandVendor
    {
        public int BrandID { get; set; }
        public int VendorID { get; set; }
        public string VendorBrandCode { get; set; }
        public string Name { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
