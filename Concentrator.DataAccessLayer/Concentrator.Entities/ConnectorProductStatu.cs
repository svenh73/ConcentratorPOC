using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorProductStatu
    {
        public int ConnectorID { get; set; }
        public string ConnectorStatus { get; set; }
        public int ConcentratorStatusID { get; set; }
        public Nullable<int> ConnectorStatusID { get; set; }
        public int ConnectorProductStatusID { get; set; }
        public virtual AssortmentStatu AssortmentStatu { get; set; }
    }
}
