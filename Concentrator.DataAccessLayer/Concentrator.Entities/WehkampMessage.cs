using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WehkampMessage
    {
        public int MessageID { get; set; }
        public int MessageType { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> Received { get; set; }
        public Nullable<System.DateTime> Sent { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public int Attempts { get; set; }
        public int VendorID { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
