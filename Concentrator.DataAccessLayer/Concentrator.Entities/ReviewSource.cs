using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ReviewSource
    {
        public ReviewSource()
        {
            this.ProductReviews = new List<ProductReview>();
        }

        public int SourceID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string LanguageCode { get; set; }
        public string SourceUrl { get; set; }
        public string SourceLogoUrl { get; set; }
        public Nullable<int> SourceRank { get; set; }
        public Nullable<int> CustomSourceID { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
    }
}
