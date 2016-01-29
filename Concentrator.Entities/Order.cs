using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Order
    {
        public Order()
        {
            this.DatcolLinks = new List<DatcolLink>();
            this.OrderLines = new List<OrderLine>();
            this.OrderResponses = new List<OrderResponse>();
            this.Outbounds = new List<Outbound>();
            this.RefundQueues = new List<RefundQueue>();
        }

        public int OrderID { get; set; }
        public string Document { get; set; }
        public int ConnectorID { get; set; }
        public bool IsDispatched { get; set; }
        public Nullable<System.DateTime> DispatchToVendorDate { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public Nullable<bool> isDropShipment { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> ShipToCustomerID { get; set; }
        public string CustomerOrderReference { get; set; }
        public string EdiVersion { get; set; }
        public string BSKIdentifier { get; set; }
        public string WebSiteOrderNumber { get; set; }
        public string PaymentTermsCode { get; set; }
        public string PaymentInstrument { get; set; }
        public Nullable<bool> BackOrdersAllowed { get; set; }
        public string RouteCode { get; set; }
        public string HoldCode { get; set; }
        public Nullable<int> SoldToCustomerID { get; set; }
        public bool HoldOrder { get; set; }
        public int OrderType { get; set; }
        public string OrderLanguageCode { get; set; }
        public string PhysicalIdentifier { get; set; }
        public string OriginatingStoreIdentifier { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual ICollection<DatcolLink> DatcolLinks { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<OrderResponse> OrderResponses { get; set; }
        public virtual ICollection<Outbound> Outbounds { get; set; }
        public virtual ICollection<RefundQueue> RefundQueues { get; set; }
    }
}
