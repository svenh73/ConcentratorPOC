using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Barcode
    {
      [Key]  
      public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public int BarcodeTypeId { get; set; }
        public string Barcode1 { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public virtual Product Product { get; set; }
        public virtual BarcodeType BarcodeType { get; set; }
    }
}
