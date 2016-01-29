using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WebToPrintQueue
    {
        public int QueueID { get; set; }
        public int ProjectID { get; set; }
        public int Status { get; set; }
        public string Data { get; set; }
        public string Message { get; set; }
        public virtual WebToPrintProject WebToPrintProject { get; set; }
    }
}
