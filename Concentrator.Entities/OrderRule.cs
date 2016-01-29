using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class OrderRule
    {
        public OrderRule()
        {
            this.ConnectorRuleValues = new List<ConnectorRuleValue>();
        }

        public int RuleID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Score { get; set; }
        public virtual ICollection<ConnectorRuleValue> ConnectorRuleValues { get; set; }
    }
}
