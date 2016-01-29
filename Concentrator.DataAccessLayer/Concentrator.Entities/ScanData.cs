using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ScanData
    {
        public int ProductGroupMappingID { get; set; }
        public string ScanTime { get; set; }
        public int ConnectorID { get; set; }
        public string ScanDisplay { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
    }
}
