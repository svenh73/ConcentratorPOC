using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductMedia
    {
        public ProductMedia()
        {
            this.ProductMediaTumbnails = new List<ProductMediaTumbnail>();
        }

        public int ProductID { get; set; }
        public int Sequence { get; set; }
        public int VendorID { get; set; }
        public int TypeID { get; set; }
        public string MediaUrl { get; set; }
        public string MediaPath { get; set; }
        public int MediaID { get; set; }
        public string Resolution { get; set; }
        public Nullable<int> Size { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public bool IsThumbNailImage { get; set; }
        public System.DateTime LastChanged { get; set; }
        public virtual MediaType MediaType { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<ProductMediaTumbnail> ProductMediaTumbnails { get; set; }
    }
}
