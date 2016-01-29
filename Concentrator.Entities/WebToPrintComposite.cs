using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WebToPrintComposite
    {
        public int CompositeID { get; set; }
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public virtual WebToPrintProject WebToPrintProject { get; set; }
    }
}
