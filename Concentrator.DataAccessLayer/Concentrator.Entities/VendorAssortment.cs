using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorAssortment
    {
        public VendorAssortment()
        {
            this.ContentLedgers = new List<ContentLedger>();
            this.VendorAccruels = new List<VendorAccruel>();
            this.VendorFreeGoods = new List<VendorFreeGood>();
            this.VendorPrices = new List<VendorPrice>();
            this.ProductGroupVendors = new List<ProductGroupVendor>();
        }

        public int VendorAssortmentID { get; set; }
        public int ProductID { get; set; }
        public string CustomItemNumber { get; set; }
        public int VendorID { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string LineType { get; set; }
        public string LedgerClass { get; set; }
        public Nullable<bool> ExtendedCatalog { get; set; }
        public string ProductDesk { get; set; }
        public string ActivationKey { get; set; }
        public bool IsActive { get; set; }
        public string ZoneReferenceID { get; set; }
        public string ShipmentRateTableReferenceID { get; set; }
        public virtual ICollection<ContentLedger> ContentLedgers { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<VendorAccruel> VendorAccruels { get; set; }
        public virtual ICollection<VendorFreeGood> VendorFreeGoods { get; set; }
        public virtual ICollection<VendorPrice> VendorPrices { get; set; }
        public virtual ICollection<ProductGroupVendor> ProductGroupVendors { get; set; }
    }
}
