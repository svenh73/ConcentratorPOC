using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class FunctionalityRole
    {
        public int RoleID { get; set; }
        public string FunctionalityName { get; set; }
        public virtual Role Role { get; set; }
    }
}
