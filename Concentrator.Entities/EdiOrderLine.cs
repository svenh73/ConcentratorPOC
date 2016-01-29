using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class EdiOrderLine
    {
        public EdiOrderLine()
        {
            this.EdiOrderLedgers = new List<EdiOrderLedger>();
            this.EdiOrderResponseLines = new List<EdiOrderResponseLine>();
        }

        public int EdiOrderLineID { get; set; }
        public string Remarks { get; set; }
        public int EdiOrderID { get; set; }
        public string CustomerEdiOrderLineNr { get; set; }
        public string CustomerOrderNr { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<double> Price { get; set; }
        public int Quantity { get; set; }
        public bool isDispatched { get; set; }
        public Nullable<int> DispatchedToVendorID { get; set; }
        public Nullable<int> VendorOrderNumber { get; set; }
        public string Response { get; set; }
        public Nullable<bool> CentralDelivery { get; set; }
        public string CustomerItemNumber { get; set; }
        public string WareHouseCode { get; set; }
        public bool PriceOverride { get; set; }
        public string EndCustomerOrderNr { get; set; }
        public string Currency { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ProductDescription { get; set; }
        public string EdiProductID { get; set; }
        public string CompanyCode { get; set; }
        public virtual EdiOrder EdiOrder { get; set; }
        public virtual ICollection<EdiOrderLedger> EdiOrderLedgers { get; set; }
        public virtual ICollection<EdiOrderResponseLine> EdiOrderResponseLines { get; set; }
    }
}
