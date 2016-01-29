using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PriceCorrection
    {
        public int PriceCorrectionID { get; set; }
        public string ProductID { get; set; }
        public string AdditionalLine { get; set; }
        public System.DateTime CreationTime { get; set; }
    }
}
