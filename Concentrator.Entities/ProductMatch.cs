using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductMatch
    {
        public int ProductMatchID { get; set; }
        public int ProductID { get; set; }
        public bool isMatched { get; set; }
        public Nullable<int> MatchPercentage { get; set; }
        public Nullable<bool> CalculatedMatch { get; set; }
        public int MatchStatus { get; set; }
        public Nullable<bool> Primary { get; set; }
        public virtual Product Product { get; set; }
    }
}
