using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderLineMap : EntityTypeConfiguration<OrderLine>
    {
        public OrderLineMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderLineID);

            // Properties
            this.Property(t => t.CustomerOrderLineNr)
                .HasMaxLength(100);

            this.Property(t => t.CustomerOrderNr)
                .HasMaxLength(100);

            this.Property(t => t.CustomerItemNumber)
                .HasMaxLength(100);

            this.Property(t => t.WareHouseCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderLine");
            this.Property(t => t.OrderLineID).HasColumnName("OrderLineID");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.CustomerOrderLineNr).HasColumnName("CustomerOrderLineNr");
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
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.LineDiscount).HasColumnName("LineDiscount");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.OriginalLine).HasColumnName("OriginalLine");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(d => d.OrderID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(d => d.DispatchedToVendorID);

        }
    }
}
