using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMappingMedia
    {
        public int MasterGroupMappingMediaID { get; set; }
        public int MasterGroupMappingID { get; set; }
        public int ImageTypeID { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public System.DateTime CreationTime { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual Language Language { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping { get; set; }
    }
}
