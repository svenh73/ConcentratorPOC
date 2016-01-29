using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ManagementGroup
    {
        public ManagementGroup()
        {
            this.ManagementPages = new List<ManagementPage>();
        }

        public int GroupID { get; set; }
        public string Group { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string DashboardName { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual ICollection<ManagementPage> ManagementPages { get; set; }
    }
}
