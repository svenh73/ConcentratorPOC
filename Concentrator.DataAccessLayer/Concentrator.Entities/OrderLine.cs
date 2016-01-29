using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class OrderLine
    {
        public OrderLine()
        {
            this.OrderLedgers = new List<OrderLedger>();
            this.OrderResponseLines = new List<OrderResponseLine>();
            this.OrderLineAppliedDiscountRules = new List<OrderLineAppliedDiscountRule>();
        }

        public int OrderLineID { get; set; }
        public string Remarks { get; set; }
        public int OrderID { get; set; }
        public string CustomerOrderLineNr { get; set; }
        public string CustomerOrderNr { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<double> Price { get; set; }
        public int Quantity { get; set; }
        public bool isDispatched { get; set; }
        public Nullable<int> DispatchedToVendorID { get; set; }
        public Nullable<int> VendorOrderNumber { get; set; }
        public string Response { get; set; }
        public Nullable<bool> CentralDelivery { get; set; }
        public string CustomerItemNumber { get; set; }
        public string WareHouseCode { get; set; }
        public bool PriceOverride { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> LineDiscount { get; set; }
        public Nullable<double> BasePrice { get; set; }
        public string OriginalLine { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<OrderLedger> OrderLedgers { get; set; }
        public virtual Product Product { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<OrderResponseLine> OrderResponseLines { get; set; }
        public virtual ICollection<OrderLineAppliedDiscountRule> OrderLineAppliedDiscountRules { get; set; }
    }
}
