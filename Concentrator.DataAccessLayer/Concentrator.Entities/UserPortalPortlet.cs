using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserPortalPortlet
    {
        public int UserID { get; set; }
        public int PortalID { get; set; }
        public int PortletID { get; set; }
        public Nullable<int> Column { get; set; }
        public Nullable<int> Row { get; set; }
        public virtual Portlet Portlet { get; set; }
        public virtual UserPortal UserPortal { get; set; }
    }
}
