using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrder
    {
        public EdiOrder()
        {
            this.EdiOrderLines = new List<EdiOrderLine>();
            this.EdiOrderPosts = new List<EdiOrderPost>();
            this.EdiOrderResponses = new List<EdiOrderResponse>();
        }

        public int EdiOrderID { get; set; }
        public int EdiRequestID { get; set; }
        public string Document { get; set; }
        public int ConnectorID { get; set; }
        public bool IsDispatched { get; set; }
        public Nullable<System.DateTime> DispatchToVendorDate { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public Nullable<bool> isDropShipment { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> ShipToCustomerID { get; set; }
        public Nullable<int> SoldToCustomerID { get; set; }
        public string CustomerOrderReference { get; set; }
        public string EdiVersion { get; set; }
        public Nullable<int> BSKIdentifier { get; set; }
        public string WebSiteOrderNumber { get; set; }
        public string PaymentTermsCode { get; set; }
        public string PaymentInstrument { get; set; }
        public Nullable<bool> BackOrdersAllowed { get; set; }
        public string RouteCode { get; set; }
        public string HoldCode { get; set; }
        public bool HoldOrder { get; set; }
        public int Status { get; set; }
        public int EdiOrderTypeID { get; set; }
        public Nullable<bool> PartialDelivery { get; set; }
        public Nullable<int> ConnectorRelationID { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ConnectorRelation ConnectorRelation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
        public virtual EdiOrderListener EdiOrderListener { get; set; }
        public virtual EdiOrderType EdiOrderType { get; set; }
        public virtual ICollection<EdiOrderLine> EdiOrderLines { get; set; }
        public virtual ICollection<EdiOrderPost> EdiOrderPosts { get; set; }
        public virtual ICollection<EdiOrderResponse> EdiOrderResponses { get; set; }
    }
}
