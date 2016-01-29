using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderListener
    {
        public EdiOrderListener()
        {
            this.EdiOrders = new List<EdiOrder>();
            this.EdiOrderPosts = new List<EdiOrderPost>();
        }

        public int EdiRequestID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerIP { get; set; }
        public string CustomerHostName { get; set; }
        public string RequestDocument { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
        public Nullable<bool> Processed { get; set; }
        public string ResponseRemark { get; set; }
        public Nullable<int> ResponseTime { get; set; }
        public string ErrorMessage { get; set; }
        public int ConnectorID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders { get; set; }
        public virtual ICollection<EdiOrderPost> EdiOrderPosts { get; set; }
    }
}
