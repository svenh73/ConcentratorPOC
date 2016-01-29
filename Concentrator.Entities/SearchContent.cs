using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class SearchContent
    {
        public Nullable<int> ProductID { get; set; }
        public string VendorItemNumber { get; set; }
        public string BrandName { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public string ModelName { get; set; }
        public string CustomItemNumber { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImagePath { get; set; }
        public string ShortContentDescription { get; set; }
        public string SearchText { get; set; }
        public int SearchContentID { get; set; }
    }
}
