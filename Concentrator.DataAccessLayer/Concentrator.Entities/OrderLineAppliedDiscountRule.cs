using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class OrderLineAppliedDiscountRule
    {
        public int AppliedRuleID { get; set; }
        public string Code { get; set; }
        public int RuleID { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool Percentage { get; set; }
        public int OrderLineID { get; set; }
        public bool IsSet { get; set; }
        public virtual OrderLine OrderLine { get; set; }
    }
}
