using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentProductMatch
    {
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public bool IsLeading { get; set; }
        public virtual Product Product { get; set; }
    }
}
