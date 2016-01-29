using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ScanProvider
    {
        public int ScanProviderID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int PriceType { get; set; }
        public bool IncludeShippingCost { get; set; }
        public virtual ScanProvider ScanProvider1 { get; set; }
        public virtual ScanProvider ScanProvider2 { get; set; }
    }
}
