using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductReview
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int SourceID { get; set; }
        public string Author { get; set; }
        public bool IsSummary { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Title { get; set; }
        public string Verdict { get; set; }
        public string Summary { get; set; }
        public string ReviewURL { get; set; }
        public Nullable<int> SourceRating { get; set; }
        public string CustomID { get; set; }
        public string RatingImageURL { get; set; }
        public virtual Product Product { get; set; }
        public virtual ReviewSource ReviewSource { get; set; }
    }
}
