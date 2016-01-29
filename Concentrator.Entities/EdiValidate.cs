using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiValidate
    {
        public int EdiValidateID { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public int EdiVendorID { get; set; }
        public Nullable<int> MaxLength { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public int EdiType { get; set; }
        public int EdiValidationType { get; set; }
        public int EdiConnectionType { get; set; }
        public string Connection { get; set; }
        public virtual EdiVendor EdiVendor { get; set; }
    }
}
