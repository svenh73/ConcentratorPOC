using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiVendor
    {
        public EdiVendor()
        {
            this.ConnectorRelations = new List<ConnectorRelation>();
            this.EdiFieldMappings = new List<EdiFieldMapping>();
            this.EdiValidates = new List<EdiValidate>();
        }

        public int EdiVendorID { get; set; }
        public string Name { get; set; }
        public string EdiVendorType { get; set; }
        public string CompanyCode { get; set; }
        public string DefaultDocumentType { get; set; }
        public string OrderBy { get; set; }
        public virtual ICollection<ConnectorRelation> ConnectorRelations { get; set; }
        public virtual ICollection<EdiFieldMapping> EdiFieldMappings { get; set; }
        public virtual ICollection<EdiValidate> EdiValidates { get; set; }
    }
}
