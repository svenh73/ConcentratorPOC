using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class PortalNotification
    {
        public int FormID { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string ArticleNumber { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> NotificationType { get; set; }
        public string Description { get; set; }
        public System.DateTime CreationTime { get; set; }
        public bool IsResolved { get; set; }
    }
}
