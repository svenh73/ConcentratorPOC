using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class SlurpSchedule
    {
        public SlurpSchedule()
        {
            this.SlurpQueues = new List<SlurpQueue>();
        }

        public int SlurpScheduleID { get; set; }
        public int ProductCompareSourceID { get; set; }
        public Nullable<int> ProductGroupMappingID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int Interval { get; set; }
        public int IntervalType { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductCompareSource ProductCompareSource { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping { get; set; }
        public virtual ICollection<SlurpQueue> SlurpQueues { get; set; }
    }
}
