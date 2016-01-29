using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class OrderItemFullfilmentInformation
    {
        public int OrderResponseLineID { get; set; }
        public string Sequence { get; set; }
        public string Type { get; set; }
        public string Header { get; set; }
        public string Unit { get; set; }
        public string SupportType { get; set; }
        public string SupportID { get; set; }
        public string Label { get; set; }
        public string Code { get; set; }
        public int OrderFullfilmentInformationID { get; set; }
        public string Value { get; set; }
        public virtual OrderResponseLine OrderResponseLine { get; set; }
    }
}
