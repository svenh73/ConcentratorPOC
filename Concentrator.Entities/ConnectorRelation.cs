using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorRelation
    {
        public ConnectorRelation()
        {
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.EdiOrders = new List<EdiOrder>();
            this.EdiOrderPosts = new List<EdiOrderPost>();
            this.EdiOrderResponses = new List<EdiOrderResponse>();
        }

        public string CustomerID { get; set; }
        public Nullable<bool> OrderConfirmation { get; set; }
        public Nullable<bool> ShipmentConfirmation { get; set; }
        public Nullable<bool> InvoiceConfirmation { get; set; }
        public string OutboundTo { get; set; }
        public string OutboundPassword { get; set; }
        public string OutboundUsername { get; set; }
        public Nullable<int> ConnectorType { get; set; }
        public Nullable<int> OutboundMessageType { get; set; }
        public string AuthorisationAddresses { get; set; }
        public Nullable<int> AccountPrivileges { get; set; }
        public Nullable<bool> UseFtp { get; set; }
        public Nullable<int> ProviderType { get; set; }
        public Nullable<int> FtpType { get; set; }
        public Nullable<int> FtpFrequency { get; set; }
        public string FtpAddress { get; set; }
        public string FtpPass { get; set; }
        public Nullable<int> FtpPort { get; set; }
        public Nullable<int> XtractType { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> FtpConnectionType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int ConnectorRelationID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string OutboundOrderConfirmation { get; set; }
        public string OutboundShipmentConfirmation { get; set; }
        public string OutboundInvoiceConfirmation { get; set; }
        public string AdministrationCode { get; set; }
        public string OrderType { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public Nullable<int> EdiVendorID { get; set; }
        public string FreightProduct { get; set; }
        public string FinChargesProduct { get; set; }
        public string Email { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual EdiVendor EdiVendor { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders { get; set; }
        public virtual ICollection<EdiOrderPost> EdiOrderPosts { get; set; }
        public virtual ICollection<EdiOrderResponse> EdiOrderResponses { get; set; }
    }
}
