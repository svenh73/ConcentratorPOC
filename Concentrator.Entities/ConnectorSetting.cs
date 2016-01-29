using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorSetting
    {
        public int ConnectorID { get; set; }
        public string SettingKey { get; set; }
        public string Value { get; set; }
        public virtual Connector Connector { get; set; }
    }
}
