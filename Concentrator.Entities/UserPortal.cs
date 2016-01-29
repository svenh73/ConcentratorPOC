using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserPortal
    {
        public UserPortal()
        {
            this.UserPortalPortlets = new List<UserPortalPortlet>();
        }

        public int PortalID { get; set; }
        public int UserID { get; set; }
        public Nullable<decimal> West { get; set; }
        public Nullable<decimal> East { get; set; }
        public virtual Portal Portal { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserPortalPortlet> UserPortalPortlets { get; set; }
    }
}
