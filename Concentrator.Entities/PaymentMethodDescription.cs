using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PaymentMethodDescription
    {
        public int PaymentMethodID { get; set; }
        public int LanguageID { get; set; }
        public string Description { get; set; }
        public virtual Language Language { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
