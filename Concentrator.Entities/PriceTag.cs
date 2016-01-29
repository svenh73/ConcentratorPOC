using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PriceTag
    {
        public int PriceTagID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLandscape { get; set; }
        public string PageSize { get; set; }
        public bool HasFreeTextLine { get; set; }
        public string Action { get; set; }
        public Nullable<int> MaximumQuantity { get; set; }
        public string Icon { get; set; }
    }
}
