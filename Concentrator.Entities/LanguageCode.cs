using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class LanguageCode
    {
        public int Id { get; set; }
        public int connectorID { get; set; }
        public string magentoWebsiteStoreCode { get; set; }
        public string Lang { get; set; }
    }
}
