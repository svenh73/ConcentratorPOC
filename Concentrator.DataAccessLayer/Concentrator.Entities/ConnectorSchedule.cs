using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ConnectorSchedule
    {
        public int ConnectorScheduleID { get; set; }
        public int ConnectorID { get; set; }
        public int PluginID { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public string Duration { get; set; }
        public Nullable<System.DateTime> ScheduledNextRun { get; set; }
        public int ConnectorScheduleStatus { get; set; }
        public Nullable<bool> ExecuteOnStartup { get; set; }
        public string CronExpression { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Plugin Plugin { get; set; }
    }
}
