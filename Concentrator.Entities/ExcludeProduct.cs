using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ExcludeProduct
    {
        public int ExcludeProductID { get; set; }
        public int ConnectorID { get; set; }
        public string Value { get; set; }
        public virtual Connector Connector { get; set; }
    }
}
