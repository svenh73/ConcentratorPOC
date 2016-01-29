using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorLanguage
    {
        public int ConnectorLanguageID { get; set; }
        public int ConnectorID { get; set; }
        public int LanguageID { get; set; }
        public string Country { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Language Language { get; set; }
    }
}
