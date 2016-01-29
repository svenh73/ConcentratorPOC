using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MissingContent
    {
        public int ConcentratorProductID { get; set; }
        public int ConnectorID { get; set; }
        public bool isActive { get; set; }
        public string VendorItemNumber { get; set; }
        public string CustomItemNumber { get; set; }
        public string BrandName { get; set; }
        public string ShortDescription { get; set; }
        public int ProductGroupID { get; set; }
        public int BrandID { get; set; }
        public bool Image { get; set; }
        public bool YouTube { get; set; }
        public bool Specifications { get; set; }
        public string ContentVendor { get; set; }
        public Nullable<int> ContentVendorID { get; set; }
        public string Barcode { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public bool IsConfigurable { get; set; }
        public bool HasDescription { get; set; }
        public int QuantityOnHand { get; set; }
        public bool HasFrDescription { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Product Product { get; set; }
    }
}
