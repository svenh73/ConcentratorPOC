using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Plugin
    {
        public Plugin()
        {
            this.ConnectorSchedules = new List<ConnectorSchedule>();
            this.Events = new List<Event>();
            this.UserPlugins = new List<UserPlugin>();
        }

        public int PluginID { get; set; }
        public string PluginName { get; set; }
        public string PluginType { get; set; }
        public string PluginGroup { get; set; }
        public string CronExpression { get; set; }
        public bool ExecuteOnStartup { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public Nullable<System.DateTime> NextRun { get; set; }
        public string Duration { get; set; }
        public bool IsActive { get; set; }
        public int JobServer { get; set; }
        public virtual ICollection<ConnectorSchedule> ConnectorSchedules { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<UserPlugin> UserPlugins { get; set; }
    }
}
