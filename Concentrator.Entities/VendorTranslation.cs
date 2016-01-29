using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorTranslation
    {
        public int SourceVendorID { get; set; }
        public string SourceVendorValue { get; set; }
        public int DestinationVendorID { get; set; }
        public string DestinationVendorValue { get; set; }
        public int TranslationType { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Vendor Vendor1 { get; set; }
    }
}
