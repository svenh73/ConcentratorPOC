using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WebToPrintBinding
    {
        public WebToPrintBinding()
        {
            this.WebToPrintBindingFields = new List<WebToPrintBindingField>();
        }

        public int BindingID { get; set; }
        public string Name { get; set; }
        public string Query { get; set; }
        public string QueryText { get; set; }
        public virtual ICollection<WebToPrintBindingField> WebToPrintBindingFields { get; set; }
    }
}
