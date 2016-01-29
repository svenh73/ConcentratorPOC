using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupVendor
    {
        public ProductGroupVendor()
        {
            this.MasterGroupMappings = new List<MasterGroupMapping>();
            this.VendorAssortments = new List<VendorAssortment>();
        }

        public int ProductGroupVendorID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string BrandCode { get; set; }
        public string VendorProductGroupCode1 { get; set; }
        public string VendorProductGroupCode2 { get; set; }
        public string VendorProductGroupCode3 { get; set; }
        public string VendorProductGroupCode4 { get; set; }
        public string VendorProductGroupCode5 { get; set; }
        public string VendorProductGroupCode6 { get; set; }
        public string VendorProductGroupCode7 { get; set; }
        public string VendorProductGroupCode8 { get; set; }
        public string VendorProductGroupCode9 { get; set; }
        public string VendorProductGroupCode10 { get; set; }
        public bool IsBlocked { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
        public virtual ICollection<VendorAssortment> VendorAssortments { get; set; }
    }
}
