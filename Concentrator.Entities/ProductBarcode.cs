using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductBarcode
    {
        public int ProductID { get; set; }
        public string Barcode { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> BarcodeType { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
