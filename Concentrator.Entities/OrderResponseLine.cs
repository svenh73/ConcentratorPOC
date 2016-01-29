using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class OrderResponseLine
    {
        public OrderResponseLine()
        {
            this.OrderItemFullfilmentInformations = new List<OrderItemFullfilmentInformation>();
        }

        public int OrderResponseLineID { get; set; }
        public int OrderResponseID { get; set; }
        public Nullable<int> OrderLineID { get; set; }
        public int Ordered { get; set; }
        public int Backordered { get; set; }
        public int Cancelled { get; set; }
        public int Shipped { get; set; }
        public int Invoiced { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string VendorLineNumber { get; set; }
        public string VendorItemNumber { get; set; }
        public string OEMNumber { get; set; }
        public string Barcode { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public bool Processed { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<decimal> vatPercentage { get; set; }
        public string CarrierCode { get; set; }
        public Nullable<int> NumberOfPallets { get; set; }
        public Nullable<int> NumberOfUnits { get; set; }
        public string TrackAndTrace { get; set; }
        public string SerialNumbers { get; set; }
        public int Delivered { get; set; }
        public string TrackAndTraceLink { get; set; }
        public string ProductName { get; set; }
        public string html { get; set; }
        public Nullable<int> ProductID { get; set; }
        public virtual ICollection<OrderItemFullfilmentInformation> OrderItemFullfilmentInformations { get; set; }
        public virtual OrderLine OrderLine { get; set; }
        public virtual OrderResponse OrderResponse { get; set; }
        public virtual Product Product { get; set; }
    }
}
