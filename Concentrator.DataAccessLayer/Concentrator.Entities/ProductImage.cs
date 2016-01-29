using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductImage
    {
        public int ImageID { get; set; }
        public int ProductID { get; set; }
        public int Sequence { get; set; }
        public int VendorID { get; set; }
        public string ImageUrl { get; set; }
        public string ImagePath { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
