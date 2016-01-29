using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Event
    {
        public int EventID { get; set; }
        public int TypeID { get; set; }
        public string Message { get; set; }
        public string ProcessName { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string ExceptionLocation { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> PluginID { get; set; }
        public bool Notified { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual Plugin Plugin { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
