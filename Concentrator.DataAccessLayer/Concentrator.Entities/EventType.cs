using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EventType
    {
        public EventType()
        {
            this.Events = new List<Event>();
            this.UserPlugins = new List<UserPlugin>();
        }

        public int TypeID { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<UserPlugin> UserPlugins { get; set; }
    }
}
