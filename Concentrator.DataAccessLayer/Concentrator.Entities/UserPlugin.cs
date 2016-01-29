using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserPlugin
    {
        public int UserID { get; set; }
        public int PluginID { get; set; }
        public int TypeID { get; set; }
        public System.DateTime SubscriptionTime { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual Plugin Plugin { get; set; }
        public virtual User User { get; set; }
    }
}
