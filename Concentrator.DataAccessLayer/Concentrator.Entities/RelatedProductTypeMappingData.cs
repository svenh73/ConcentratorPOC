using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class RelatedProductTypeMappingData
    {
        public int RelatedProductTypeMappingID { get; set; }
        public int RelatedProductTypeID { get; set; }
        public int ConnectorID { get; set; }
    }
}
