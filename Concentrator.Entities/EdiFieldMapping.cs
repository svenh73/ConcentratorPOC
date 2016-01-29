using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiFieldMapping
    {
        public int EdiMappingID { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public int EdiVendorID { get; set; }
        public string VendorFieldName { get; set; }
        public string VendorTableName { get; set; }
        public string VendorFieldLength { get; set; }
        public string VendorDefaultValue { get; set; }
        public int EdiType { get; set; }
        public Nullable<int> EdiCommunicationID { get; set; }
        public bool MatchField { get; set; }
        public Nullable<int> VendorFieldType { get; set; }
        public virtual EdiCommunication EdiCommunication { get; set; }
        public virtual EdiVendor EdiVendor { get; set; }
    }
}
