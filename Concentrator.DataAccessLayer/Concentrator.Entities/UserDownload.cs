using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserDownload
    {
        public int DownloadID { get; set; }
        public int UserID { get; set; }
        public int MediaType { get; set; }
        public string MediaPath { get; set; }
        public int MediaID { get; set; }
        public bool IsProduct { get; set; }
        public string MediaName { get; set; }
        public string ImageSize { get; set; }
        public virtual MediaType MediaType1 { get; set; }
        public virtual User User { get; set; }
    }
}
