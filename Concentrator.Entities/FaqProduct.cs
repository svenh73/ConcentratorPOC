using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class FaqProduct
    {
        public int ProductID { get; set; }
        public int FaqID { get; set; }
        public int LanguageID { get; set; }
        public string Answer { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual Faq Faq { get; set; }
        public virtual Language Language { get; set; }
        public virtual Product Product { get; set; }
    }
}
