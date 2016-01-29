using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorSystem
    {
        public ConnectorSystem()
        {
            this.Connectors = new List<Connector>();
        }

        public int ConnectorSystemID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }
    }
}
