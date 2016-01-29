using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentAttribute
    {
        public int AttributeID { get; set; }
        public bool IsSearchable { get; set; }
        public bool IsVisible { get; set; }
        public string Sign { get; set; }
        public int GroupID { get; set; }
        public bool NeedsUpdate { get; set; }
        public string AttributeCode { get; set; }
        public int GroupIndex { get; set; }
        public Nullable<int> OrderIndex { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string AttributeValue { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public string AttributeName { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> VendorID { get; set; }
        public int ContentAttributeID { get; set; }
        public string AttributePath { get; set; }
        public Nullable<int> AttributeValueID { get; set; }
        public bool IsConfigurable { get; set; }
        public string AttributeOriginalValue { get; set; }
        public Nullable<int> ConfigurablePosition { get; set; }
    }
}
