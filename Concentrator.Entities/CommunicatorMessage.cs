using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class CommunicatorMessage
    {
        public CommunicatorMessage()
        {
            this.Vendors = new List<Vendor>();
        }

        public int ID { get; set; }
        public int Type { get; set; }
        public string LocalSubPath { get; set; }
        public string RemoteSubPath { get; set; }
        public bool Incoming { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
