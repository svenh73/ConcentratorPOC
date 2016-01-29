using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderResponseLine
    {
        public int EdiOrderResponseLineID { get; set; }
        public int EdiOrderResponseID { get; set; }
        public Nullable<int> EdiOrderLineID { get; set; }
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
        public bool processed { get; set; }
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
        public virtual EdiOrderLine EdiOrderLine { get; set; }
        public virtual EdiOrderResponse EdiOrderResponse { get; set; }
    }
}