using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class DatcolLink
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public string ShopNumber { get; set; }
        public System.DateTime DateCreated { get; set; }
        public decimal Amount { get; set; }
        public string DatcolNumber { get; set; }
        public string SourceMessage { get; set; }
        public virtual Order Order { get; set; }
    }
}
