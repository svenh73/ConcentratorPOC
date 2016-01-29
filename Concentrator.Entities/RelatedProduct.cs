using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class RelatedProduct
    {
        public int ProductID { get; set; }
        public int RelatedProductID { get; set; }
        public Nullable<bool> Preferred { get; set; }
        public Nullable<bool> Reversed { get; set; }
        public System.DateTime CreationTime { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public int VendorID { get; set; }
        public int RelatedProductTypeID { get; set; }
        public bool IsConfigured { get; set; }
        public bool IsActive { get; set; }
        public int Index { get; set; }
        public bool MarkedForDeletion { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
        public virtual RelatedProductType RelatedProductType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
