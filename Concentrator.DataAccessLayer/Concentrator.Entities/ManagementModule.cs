using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ManagementModule
    {
        public ManagementModule()
        {
            this.ManagementModuleItems = new List<ManagementModuleItem>();
        }

        public int ModuleID { get; set; }
        public string Name { get; set; }
        public string IconClass { get; set; }
        public virtual ICollection<ManagementModuleItem> ManagementModuleItems { get; set; }
    }
}
