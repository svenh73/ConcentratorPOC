using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class VendorProduct
    {
        public VendorProduct()
        {
            this.Prices = new List<Price>();
            this.Stocks = new List<Stock>();
            this.Vendors = new List<Vendor>();
        }
      [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public int VendorId { get; set; }
        public string VendorIdentifier { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastModified { get; set; }
        public System.DateTime Created { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
