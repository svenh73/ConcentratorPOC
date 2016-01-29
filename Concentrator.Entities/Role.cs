using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Role
    {
        public Role()
        {
            this.FunctionalityRoles = new List<FunctionalityRole>();
            this.ManagementPages = new List<ManagementPage>();
            this.UserRoles = new List<UserRole>();
            this.Portlets = new List<Portlet>();
        }

        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool isHidden { get; set; }
        public virtual ICollection<FunctionalityRole> FunctionalityRoles { get; set; }
        public virtual ICollection<ManagementPage> ManagementPages { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Portlet> Portlets { get; set; }
    }
}
