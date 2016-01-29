using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserRole
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int VendorID { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
