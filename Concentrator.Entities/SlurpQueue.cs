using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class SlurpQueue
    {
        public int QueueID { get; set; }
        public int ProductID { get; set; }
        public int ProductCompareSourceID { get; set; }
        public Nullable<int> SlurpScheduleID { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<System.DateTime> CompletionTime { get; set; }
        public bool IsCompleted { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductCompareSource ProductCompareSource { get; set; }
        public virtual SlurpSchedule SlurpSchedule { get; set; }
    }
}
