using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PaymentProvider
    {
        public PaymentProvider()
        {
            this.ConnectorPaymentProviders = new List<ConnectorPaymentProvider>();
        }

        public int PaymentProviderID { get; set; }
        public string Name { get; set; }
        public string ProviderType { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ConnectorPaymentProvider> ConnectorPaymentProviders { get; set; }
    }
}
