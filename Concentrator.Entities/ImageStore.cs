using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ImageStore
    {
        public int ImageID { get; set; }
        public string ManufacturerID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> SizeID { get; set; }
        public string CustomerProductID { get; set; }
        public Nullable<int> ProductGroupID { get; set; }
        public string ImageType { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string BrandCode { get; set; }
        public Nullable<int> ConcentratorProductID { get; set; }
    }
}
