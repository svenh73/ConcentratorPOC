using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentLedger
    {
        public int LedgerID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime LedgerDate { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<int> ConcentratorStatusID { get; set; }
        public Nullable<int> MinimumQuantity { get; set; }
        public Nullable<int> VendorAssortmentID { get; set; }
        public string Remark { get; set; }
        public string LedgerObject { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
        public Nullable<decimal> BaseCostPrice { get; set; }
        public virtual Product Product { get; set; }
        public virtual VendorAssortment VendorAssortment { get; set; }
    }
}
