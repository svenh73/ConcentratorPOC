using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Portal
    {
        public Portal()
        {
            this.ManagementGroups = new List<ManagementGroup>();
            this.UserPortals = new List<UserPortal>();
        }

        public int PortalID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ManagementGroup> ManagementGroups { get; set; }
        public virtual ICollection<UserPortal> UserPortals { get; set; }
    }
}
