using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            this.EdiOrders = new List<EdiOrder>();
            this.EdiOrders1 = new List<EdiOrder>();
            this.EdiOrderResponses = new List<EdiOrderResponse>();
            this.EdiOrderResponses1 = new List<EdiOrderResponse>();
            this.Orders = new List<Order>();
            this.Orders1 = new List<Order>();
            this.OrderResponses = new List<OrderResponse>();
            this.OrderResponses1 = new List<OrderResponse>();
        }

        public int CustomerID { get; set; }
        public string CustomerTelephone { get; set; }
        public string CustomerEmail { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressLine3 { get; set; }
        public string EANIdentifier { get; set; }
        public string CustomerName { get; set; }
        public string HouseNumber { get; set; }
        public string CoCNumber { get; set; }
        public string TaxID { get; set; }
        public string CompanyName { get; set; }
        public string ServicePointCode { get; set; }
        public string ServicePointID { get; set; }
        public string ServicePointName { get; set; }
        public string Street { get; set; }
        public string HouseNumberExt { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders1 { get; set; }
        public virtual ICollection<EdiOrderResponse> EdiOrderResponses { get; set; }
        public virtual ICollection<EdiOrderResponse> EdiOrderResponses1 { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> Orders1 { get; set; }
        public virtual ICollection<OrderResponse> OrderResponses { get; set; }
        public virtual ICollection<OrderResponse> OrderResponses1 { get; set; }
    }
}
