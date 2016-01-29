using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentPriceCalculation
    {
        public ContentPriceCalculation()
        {
            this.ContentPrices = new List<ContentPrice>();
        }

        public int ContentPriceCalculationID { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public string Calculation { get; set; }
        public virtual ICollection<ContentPrice> ContentPrices { get; set; }
    }
}
