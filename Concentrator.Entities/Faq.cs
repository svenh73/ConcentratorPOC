using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Faq
    {
        public Faq()
        {
            this.FaqTranslations = new List<FaqTranslation>();
            this.FaqProducts = new List<FaqProduct>();
        }

        public int FaqID { get; set; }
        public Nullable<bool> Mandatory { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public virtual ICollection<FaqTranslation> FaqTranslations { get; set; }
        public virtual ICollection<FaqProduct> FaqProducts { get; set; }
    }
}
