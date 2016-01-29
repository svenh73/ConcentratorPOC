using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderResponseMap : EntityTypeConfiguration<EdiOrderResponse>
    {
        public EdiOrderResponseMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderResponseID);

            // Properties
            this.Property(t => t.VendorDocument)
                .IsRequired();

            this.Property(t => t.VendorDocumentNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentConditionCode)
                .HasMaxLength(50);

            this.Property(t => t.PaymentConditionDiscount)
                .HasMaxLength(50);

            this.Property(t => t.PaymentConditionDiscountDescription)
                .HasMaxLength(100);

            this.Property(t => t.TrackAndTrace)
                .HasMaxLength(255);

            this.Property(t => t.InvoiceDocumentNumber)
                .HasMaxLength(50);

            this.Property(t => t.ShippingNumber)
                .HasMaxLength(50);

            this.Property(t => t.Currency)
                .HasMaxLength(50);

            this.Property(t => t.DespAdvice)
                .HasMaxLength(50);

            this.Property(t => t.TrackAndTraceLink)
                .HasMaxLength(255);

            this.Property(t => t.VendorDocumentReference)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EdiOrderResponse");
            this.Property(t => t.EdiOrderResponseID).HasColumnName("EdiOrderResponseID");
            this.Property(t => t.ResponseType).HasColumnName("ResponseType");
            this.Property(t => t.VendorDocument).HasColumnName("VendorDocument");
            this.Property(t => t.EdiVendorID).HasColumnName("EdiVendorID");
            this.Property(t => t.AdministrationCost).HasColumnName("AdministrationCost");
            this.Property(t => t.DropShipmentCost).HasColumnName("DropShipmentCost");
            this.Property(t => t.ShipmentCost).HasColumnName("ShipmentCost");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.PartialDelivery).HasColumnName("PartialDelivery");
            this.Property(t => t.VendorDocumentNumber).HasColumnName("VendorDocumentNumber");
            this.Property(t => t.VendorDocumentDate).HasColumnName("VendorDocumentDate");
            this.Property(t => t.VatPercentage).HasColumnName("VatPercentage");
            this.Property(t => t.VatAmount).HasColumnName("VatAmount");
            this.Property(t => t.TotalGoods).HasColumnName("TotalGoods");
            this.Property(t => t.TotalExVat).HasColumnName("TotalExVat");
            this.Property(t => t.TotalAmount).HasColumnName("TotalAmount");
            this.Property(t => t.PaymentConditionDays).HasColumnName("PaymentConditionDays");
            this.Property(t => t.PaymentConditionCode).HasColumnName("PaymentConditionCode");
            this.Property(t => t.PaymentConditionDiscount).HasColumnName("PaymentConditionDiscount");
            this.Property(t => t.PaymentConditionDiscountDescription).HasColumnName("PaymentConditionDiscountDescription");
            this.Property(t => t.TrackAndTrace).HasColumnName("TrackAndTrace");
            this.Property(t => t.InvoiceDocumentNumber).HasColumnName("InvoiceDocumentNumber");
            this.Property(t => t.ShippingNumber).HasColumnName("ShippingNumber");
            this.Property(t => t.ReqDeliveryDate).HasColumnName("ReqDeliveryDate");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.DespAdvice).HasColumnName("DespAdvice");
            this.Property(t => t.ShipToCustomerID).HasColumnName("ShipToCustomerID");
            this.Property(t => t.SoldToCustomerID).HasColumnName("SoldToCustomerID");
            this.Property(t => t.ReceiveDate).HasColumnName("ReceiveDate");
            this.Property(t => t.TrackAndTraceLink).HasColumnName("TrackAndTraceLink");
            this.Property(t => t.VendorDocumentReference).HasColumnName("VendorDocumentReference");
            this.Property(t => t.EdiOrderID).HasColumnName("EdiOrderID");
            this.Property(t => t.ConnectorRelationID).HasColumnName("ConnectorRelationID");

            // Relationships
            this.HasOptional(t => t.ConnectorRelation)
                .WithMany(t => t.EdiOrderResponses)
                .HasForeignKey(d => d.ConnectorRelationID);
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.EdiOrderResponses)
                .HasForeignKey(d => d.ShipToCustomerID);
            this.HasOptional(t => t.Customer1)
                .WithMany(t => t.EdiOrderResponses1)
                .HasForeignKey(d => d.SoldToCustomerID);
            this.HasOptional(t => t.EdiOrder)
                .WithMany(t => t.EdiOrderResponses)
                .HasForeignKey(d => d.EdiOrderID);

        }
    }
}
