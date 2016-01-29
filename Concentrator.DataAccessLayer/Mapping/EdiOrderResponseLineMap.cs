using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderResponseLineMap : EntityTypeConfiguration<EdiOrderResponseLine>
    {
        public EdiOrderResponseLineMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderResponseLineID);

            // Properties
            this.Property(t => t.Unit)
                .HasMaxLength(50);

            this.Property(t => t.VendorLineNumber)
                .HasMaxLength(50);

            this.Property(t => t.VendorItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.OEMNumber)
                .HasMaxLength(50);

            this.Property(t => t.Barcode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.CarrierCode)
                .HasMaxLength(50);

            this.Property(t => t.TrackAndTrace)
                .HasMaxLength(255);

            this.Property(t => t.SerialNumbers)
                .HasMaxLength(255);

            this.Property(t => t.TrackAndTraceLink)
                .HasMaxLength(255);

            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EdiOrderResponseLine");
            this.Property(t => t.EdiOrderResponseLineID).HasColumnName("EdiOrderResponseLineID");
            this.Property(t => t.EdiOrderResponseID).HasColumnName("EdiOrderResponseID");
            this.Property(t => t.EdiOrderLineID).HasColumnName("EdiOrderLineID");
            this.Property(t => t.Ordered).HasColumnName("Ordered");
            this.Property(t => t.Backordered).HasColumnName("Backordered");
            this.Property(t => t.Cancelled).HasColumnName("Cancelled");
            this.Property(t => t.Shipped).HasColumnName("Shipped");
            this.Property(t => t.Invoiced).HasColumnName("Invoiced");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.DeliveryDate).HasColumnName("DeliveryDate");
            this.Property(t => t.VendorLineNumber).HasColumnName("VendorLineNumber");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.OEMNumber).HasColumnName("OEMNumber");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.processed).HasColumnName("processed");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");
            this.Property(t => t.VatAmount).HasColumnName("VatAmount");
            this.Property(t => t.vatPercentage).HasColumnName("vatPercentage");
            this.Property(t => t.CarrierCode).HasColumnName("CarrierCode");
            this.Property(t => t.NumberOfPallets).HasColumnName("NumberOfPallets");
            this.Property(t => t.NumberOfUnits).HasColumnName("NumberOfUnits");
            this.Property(t => t.TrackAndTrace).HasColumnName("TrackAndTrace");
            this.Property(t => t.SerialNumbers).HasColumnName("SerialNumbers");
            this.Property(t => t.Delivered).HasColumnName("Delivered");
            this.Property(t => t.TrackAndTraceLink).HasColumnName("TrackAndTraceLink");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.html).HasColumnName("html");

            // Relationships
            this.HasOptional(t => t.EdiOrderLine)
                .WithMany(t => t.EdiOrderResponseLines)
                .HasForeignKey(d => d.EdiOrderLineID);
            this.HasRequired(t => t.EdiOrderResponse)
                .WithMany(t => t.EdiOrderResponseLines)
                .HasForeignKey(d => d.EdiOrderResponseID);

        }
    }
}
