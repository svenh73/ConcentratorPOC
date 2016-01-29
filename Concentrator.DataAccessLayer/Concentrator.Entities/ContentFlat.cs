using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentFlat
    {
        public int ConnectorID { get; set; }
        public int ProductID { get; set; }
        public int LanguageID { get; set; }
        public string VendorItemNumber { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string VendorBrandCode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string LineType { get; set; }
        public string LedgerClass { get; set; }
        public string ProductDesk { get; set; }
        public Nullable<bool> ExtendedCatalog { get; set; }
        public int ProductContentID { get; set; }
        public int VendorID { get; set; }
        public string LongContentDescription { get; set; }
        public string ShortContentDescription { get; set; }
        public string ProductName { get; set; }
        public string ModelName { get; set; }
        public string WarrantyInfo { get; set; }
        public Nullable<System.DateTime> CutOffTime { get; set; }
        public Nullable<int> DeliveryHours { get; set; }
    }
}
