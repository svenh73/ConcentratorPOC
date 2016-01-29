using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ManagementPage
    {
        public ManagementPage()
        {
            this.ExportTemplates = new List<ExportTemplate>();
        }

        public int PageID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoleID { get; set; }
        public string JSAction { get; set; }
        public string Icon { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string ID { get; set; }
        public Nullable<bool> isVisible { get; set; }
        public string FunctionalityName { get; set; }
        public virtual ICollection<ExportTemplate> ExportTemplates { get; set; }
        public virtual ManagementGroup ManagementGroup { get; set; }
        public virtual Role Role { get; set; }
    }
}
