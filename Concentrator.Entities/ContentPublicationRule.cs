using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ContentPublicationRule
    {
        public int ContentPublicationRuleID { get; set; }
        public int ProductContentID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public bool Publish { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public int RuleIndex { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> UpdateFrequentie { get; set; }
        public Nullable<int> PublicationType { get; set; }
        public virtual AssortmentStatus AssortmentStatus { get; set; }
        public virtual ContentProduct ContentProduct { get; set; }
    }
}
