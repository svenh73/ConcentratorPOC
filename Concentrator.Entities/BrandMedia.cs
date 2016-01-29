using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class BrandMedia
    {
        public int BrandID { get; set; }
        public int Sequence { get; set; }
        public int TypeID { get; set; }
        public string MediaUrl { get; set; }
        public string MediaPath { get; set; }
        public int MediaID { get; set; }
        public string Resolution { get; set; }
        public Nullable<int> Size { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
