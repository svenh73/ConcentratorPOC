using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class BarcodeType
    {
        public BarcodeType()
        {
            this.Barcodes = new List<Barcode>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Barcode> Barcodes { get; set; }
    }
}
