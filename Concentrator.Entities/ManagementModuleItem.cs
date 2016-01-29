using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ManagementModuleItem
    {
        public int ManagementModuleItemID { get; set; }
        public string Name { get; set; }
        public int RoleID { get; set; }
        public string IconClass { get; set; }
        public bool IsVisible { get; set; }
        public int ModuleID { get; set; }
        public string JSAction { get; set; }
        public virtual ManagementModule ManagementModule { get; set; }
    }
}
