using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderLineMap : EntityTypeConfiguration<EdiOrderLine>
    {
        public EdiOrderLineMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderLineID);

            // Properties
            this.Property(t => t.CustomerEdiOrderLineNr)
                .HasMaxLength(100);

            this.Property(t => t.CustomerOrderNr)
                .HasMaxLength(100);

            this.Property(t => t.CustomerItemNumber)
                .HasMaxLength(100);

            this.Property(t => t.WareHouseCode)
                .HasMaxLength(50);

            this.Property(t => t.EndCustomerOrderNr)
                .HasMaxLength(100);

            this.Property(t => t.Currency)
                .HasMaxLength(100);

            this.Property(t => t.UnitOfMeasure)
                .HasMaxLength(10);

            this.Property(t => t.ProductDescription)
                .HasMaxLength(255);

            this.Property(t => t.EdiProductID)
                .HasMaxLength(50);

            this.Property(t => t.CompanyCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EdiOrderLine");
            this.Property(t => t.EdiOrderLineID).HasColumnName("EdiOrderLineID");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.EdiOrderID).HasColumnName("EdiOrderID");
            this.Property(t => t.CustomerEdiOrderLineNr).HasColumnName("CustomerEdiOrderLineNr");
            this.Property(t => t.CustomerOrderNr).HasColumnName("CustomerOrderNr");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.isDispatched).HasColumnName("isDispatched");
            this.Property(t => t.DispatchedToVendorID).HasColumnName("DispatchedToVendorID");
            this.Property(t => t.VendorOrderNumber).HasColumnName("VendorOrderNumber");
            this.Property(t => t.Response).HasColumnName("Response");
            this.Property(t => t.CentralDelivery).HasColumnName("CentralDelivery");
            this.Property(t => t.CustomerItemNumber).HasColumnName("CustomerItemNumber");
            this.Property(t => t.WareHouseCode).HasColumnName("WareHouseCode");
            this.Property(t => t.PriceOverride).HasColumnName("PriceOverride");
            this.Property(t => t.EndCustomerOrderNr).HasColumnName("EndCustomerOrderNr");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.UnitOfMeasure).HasColumnName("UnitOfMeasure");
            this.Property(t => t.ProductDescription).HasColumnName("ProductDescription");
            this.Property(t => t.EdiProductID).HasColumnName("EdiProductID");
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");

            // Relationships
            this.HasRequired(t => t.EdiOrder)
                .WithMany(t => t.EdiOrderLines)
                .HasForeignKey(d => d.EdiOrderID);

        }
    }
}
