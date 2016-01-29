using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Portlet
    {
        public Portlet()
        {
            this.UserPortalPortlets = new List<UserPortalPortlet>();
            this.Roles = new List<Role>();
        }

        public int PortletID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserPortalPortlet> UserPortalPortlets { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
