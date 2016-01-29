using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorPaymentProvider
    {
        public int ConnectorID { get; set; }
        public int PaymentProviderID { get; set; }
        public string PaymentTermsCode { get; set; }
        public string PaymentInstrument { get; set; }
        public int Portfolio { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual PaymentProvider PaymentProvider { get; set; }
    }
}
