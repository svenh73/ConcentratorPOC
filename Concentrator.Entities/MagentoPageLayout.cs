using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MagentoPageLayout
    {
        public MagentoPageLayout()
        {
            this.ProductGroupMappings = new List<ProductGroupMapping>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
        }

        public int LayoutID { get; set; }
        public string LayoutName { get; set; }
        public string LayoutCode { get; set; }
        public virtual ICollection<ProductGroupMapping> ProductGroupMappings { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
    }
}
