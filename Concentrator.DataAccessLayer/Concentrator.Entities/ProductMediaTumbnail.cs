using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductMediaTumbnail
    {
        public int MediaID { get; set; }
        public int ThumbnailGeneratorID { get; set; }
        public string Path { get; set; }
        public virtual ProductMedia ProductMedia { get; set; }
        public virtual ThumbnailGenerator ThumbnailGenerator { get; set; }
    }
}
