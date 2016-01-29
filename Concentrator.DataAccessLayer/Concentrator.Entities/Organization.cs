using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Organization
    {
        public Organization()
        {
            this.Connectors = new List<Connector>();
            this.ProductAttributeValueLabels = new List<ProductAttributeValueLabel>();
            this.Users = new List<User>();
            this.Vendors = new List<Vendor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }
        public virtual ICollection<ProductAttributeValueLabel> ProductAttributeValueLabels { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
