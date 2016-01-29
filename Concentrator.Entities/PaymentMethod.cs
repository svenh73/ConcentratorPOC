using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            this.PaymentMethodDescriptions = new List<PaymentMethodDescription>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public virtual ICollection<PaymentMethodDescription> PaymentMethodDescriptions { get; set; }
    }
}
