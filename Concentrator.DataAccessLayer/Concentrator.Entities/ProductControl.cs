using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductControl
    {
        public int ProductControlID { get; set; }
        public string ProductControlName { get; set; }
        public bool IsActive { get; set; }
        public string ProductControlDescription { get; set; }
    }
}
