using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MediaType
    {
        public MediaType()
        {
            this.BrandMedias = new List<BrandMedia>();
            this.ProductMedias = new List<ProductMedia>();
            this.UserDownloads = new List<UserDownload>();
        }

        public int TypeID { get; set; }
        public string Type { get; set; }
        public virtual ICollection<BrandMedia> BrandMedias { get; set; }
        public virtual ICollection<ProductMedia> ProductMedias { get; set; }
        public virtual ICollection<UserDownload> UserDownloads { get; set; }
    }
}
