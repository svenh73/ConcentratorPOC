using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Price
    {
      [Key]  
      public int Id { get; set; }
        public int ChannelProductId { get; set; }
        public int VatId { get; set; }
        public int CurrencyId { get; set; }
        public int PriceTypeId { get; set; }
        public int VendorProductId { get; set; }
        public decimal Price1 { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool IncludingVAT { get; set; }
        public virtual ChannelProduct ChannelProduct { get; set; }
        public virtual Currrency Currrency { get; set; }
        public virtual PriceType PriceType { get; set; }
        public virtual VendorProduct VendorProduct { get; set; }
        public virtual VAT VAT { get; set; }
    }
}
