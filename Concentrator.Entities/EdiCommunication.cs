using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiCommunication
    {
        public EdiCommunication()
        {
            this.EdiFieldMappings = new List<EdiFieldMapping>();
        }

        public int EdiCommunicationID { get; set; }
        public string Name { get; set; }
        public string Schedule { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public Nullable<System.DateTime> NextRun { get; set; }
        public string Query { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public int EdiConnectionType { get; set; }
        public string Connection { get; set; }
        public string Remark { get; set; }
        public string ResponseType { get; set; }
        public virtual ICollection<EdiFieldMapping> EdiFieldMappings { get; set; }
    }
}
