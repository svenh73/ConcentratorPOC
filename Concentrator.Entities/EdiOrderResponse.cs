using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderResponse
    {
        public EdiOrderResponse()
        {
            this.EdiOrderResponseLines = new List<EdiOrderResponseLine>();
        }

        public int EdiOrderResponseID { get; set; }
        public int ResponseType { get; set; }
        public string VendorDocument { get; set; }
        public int EdiVendorID { get; set; }
        public Nullable<decimal> AdministrationCost { get; set; }
        public Nullable<decimal> DropShipmentCost { get; set; }
        public Nullable<decimal> ShipmentCost { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<bool> PartialDelivery { get; set; }
        public string VendorDocumentNumber { get; set; }
        public Nullable<System.DateTime> VendorDocumentDate { get; set; }
        public Nullable<decimal> VatPercentage { get; set; }
        public Nullable<decimal> VatAmount { get; set; }
        public Nullable<decimal> TotalGoods { get; set; }
        public Nullable<decimal> TotalExVat { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> PaymentConditionDays { get; set; }
        public string PaymentConditionCode { get; set; }
        public string PaymentConditionDiscount { get; set; }
        public string PaymentConditionDiscountDescription { get; set; }
        public string TrackAndTrace { get; set; }
        public string InvoiceDocumentNumber { get; set; }
        public string ShippingNumber { get; set; }
        public Nullable<System.DateTime> ReqDeliveryDate { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string Currency { get; set; }
        public string DespAdvice { get; set; }
        public Nullable<int> ShipToCustomerID { get; set; }
        public Nullable<int> SoldToCustomerID { get; set; }
        public System.DateTime ReceiveDate { get; set; }
        public string TrackAndTraceLink { get; set; }
        public string VendorDocumentReference { get; set; }
        public Nullable<int> EdiOrderID { get; set; }
        public Nullable<int> ConnectorRelationID { get; set; }
        public virtual ConnectorRelation ConnectorRelation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual EdiOrder EdiOrder { get; set; }
        public virtual ICollection<EdiOrderResponseLine> EdiOrderResponseLines { get; set; }
    }
}
