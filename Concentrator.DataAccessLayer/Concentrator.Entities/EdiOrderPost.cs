using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderPost
    {
        public int EdiOrderPostID { get; set; }
        public Nullable<int> EdiOrderID { get; set; }
        public int ConnectorRelationID { get; set; }
        public string EdiBackendOrderID { get; set; }
        public string CustomerOrderID { get; set; }
        public bool Processed { get; set; }
        public string Type { get; set; }
        public string PostDocument { get; set; }
        public string PostDocumentUrl { get; set; }
        public string PostUrl { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string ResponseRemark { get; set; }
        public Nullable<int> ResponseTime { get; set; }
        public Nullable<int> ProcessedCount { get; set; }
        public Nullable<int> EdiRequestID { get; set; }
        public string ErrorMessage { get; set; }
        public int BSKIdentifier { get; set; }
        public int DocumentCounter { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ConnectorRelation ConnectorRelation { get; set; }
        public virtual EdiOrder EdiOrder { get; set; }
        public virtual EdiOrderListener EdiOrderListener { get; set; }
    }
}
