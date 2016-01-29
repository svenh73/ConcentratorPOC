using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WebToPrintBindingField
    {
        public int FieldID { get; set; }
        public int BindingID { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public int Options { get; set; }
        public virtual WebToPrintBinding WebToPrintBinding { get; set; }
    }
}
