using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ManagementLabel
    {
        public int ManagementLabelID { get; set; }
        public string Field { get; set; }
        public string Label { get; set; }
        public string Grid { get; set; }
        public int UserID { get; set; }
    }
}
