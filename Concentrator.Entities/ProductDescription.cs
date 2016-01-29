using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductDescription
    {
        public int ProductID { get; set; }
        public int LanguageID { get; set; }
        public int VendorID { get; set; }
        public string ShortContentDescription { get; set; }
        public string LongContentDescription { get; set; }
        public string ShortSummaryDescription { get; set; }
        public string LongSummaryDescription { get; set; }
        public string PDFUrl { get; set; }
        public Nullable<int> PDFSize { get; set; }
        public string Url { get; set; }
        public string WarrantyInfo { get; set; }
        public string ModelName { get; set; }
        public string ProductName { get; set; }
        public string Quality { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public virtual Language Language { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
