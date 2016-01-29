using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ExportTemplate
    {
        public ExportTemplate()
        {
            this.ExportTemplateColumns = new List<ExportTemplateColumn>();
        }

        public int ExportTemplateID { get; set; }
        public int UserID { get; set; }
        public int ManagementPageID { get; set; }
        public string TemplateName { get; set; }
        public virtual ICollection<ExportTemplateColumn> ExportTemplateColumns { get; set; }
        public virtual ManagementPage ManagementPage { get; set; }
        public virtual User User { get; set; }
    }
}
