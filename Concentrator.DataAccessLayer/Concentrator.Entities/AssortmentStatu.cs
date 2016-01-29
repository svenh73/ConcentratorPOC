using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class AssortmentStatu
    {
        public AssortmentStatu()
        {
            this.ConnectorProductStatus = new List<ConnectorProductStatu>();
            this.ConnectorPublications = new List<ConnectorPublication>();
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ContentPublicationRules = new List<ContentPublicationRule>();
            this.VendorPrices = new List<VendorPrice>();
            this.VendorProductStatus = new List<VendorProductStatu>();
            this.VendorStocks = new List<VendorStock>();
        }

        public int StatusID { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ConnectorProductStatu> ConnectorProductStatus { get; set; }
        public virtual ICollection<ConnectorPublication> ConnectorPublications { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ContentPublicationRule> ContentPublicationRules { get; set; }
        public virtual ICollection<VendorPrice> VendorPrices { get; set; }
        public virtual ICollection<VendorProductStatu> VendorProductStatus { get; set; }
        public virtual ICollection<VendorStock> VendorStocks { get; set; }
    }
}
