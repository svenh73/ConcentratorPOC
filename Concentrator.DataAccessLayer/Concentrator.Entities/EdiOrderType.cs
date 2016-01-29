using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderType
    {
        public EdiOrderType()
        {
            this.EdiOrders = new List<EdiOrder>();
        }

        public int EdiOrderTypeID { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual ICollection<EdiOrder> EdiOrders { get; set; }
    }
}
