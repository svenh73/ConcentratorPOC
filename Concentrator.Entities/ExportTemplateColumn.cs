using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ExportTemplateColumn
    {
        public int ExportTemplateColumnID { get; set; }
        public string Name { get; set; }
        public string SortOrder { get; set; }
        public string FilterOperator { get; set; }
        public string Value { get; set; }
        public string FilterType { get; set; }
        public int ExportTemplateID { get; set; }
        public virtual ExportTemplate ExportTemplate { get; set; }
    }
}
