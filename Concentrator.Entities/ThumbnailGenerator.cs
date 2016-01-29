using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ThumbnailGenerator
    {
        public ThumbnailGenerator()
        {
            this.ProductMediaTumbnails = new List<ProductMediaTumbnail>();
        }

        public int ThumbnailGeneratorID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Nullable<int> Resolution { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual ICollection<ProductMediaTumbnail> ProductMediaTumbnails { get; set; }
    }
}
