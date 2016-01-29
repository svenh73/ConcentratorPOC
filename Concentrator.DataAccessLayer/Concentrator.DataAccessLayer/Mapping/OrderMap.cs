using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.EdiVersion)
                .HasMaxLength(50);

            this.Property(t => t.BSKIdentifier)
                .HasMaxLength(200);

            this.Property(t => t.WebSiteOrderNumber)
                .HasMaxLength(100);

            this.Property(t => t.PaymentTermsCode)
                .HasMaxLength(50);

            this.Property(t => t.PaymentInstrument)
                .HasMaxLength(50);

            this.Property(t => t.RouteCode)
                .HasMaxLength(50);

            this.Property(t => t.HoldCode)
                .HasMaxLength(50);

            this.Property(t => t.OrderLanguageCode)
                .HasMaxLength(25);

            this.Property(t => t.PhysicalIdentifier)
                .HasMaxLength(100);

            this.Property(t => t.OriginatingStoreIdentifier)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Document).HasColumnName("Document");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.IsDispatched).HasColumnName("IsDispatched");
            this.Property(t => t.DispatchToVendorDate).HasColumnName("DispatchToVendorDate");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
            this.Property(t => t.isDropShipment).HasColumnName("isDropShipment");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ShipToCustomerID).HasColumnName("ShipToCustomerID");
            this.Property(t => t.CustomerOrderReference).HasColumnName("CustomerOrderReference");
            this.Property(t => t.EdiVersion).HasColumnName("EdiVersion");
            this.Property(t => t.BSKIdentifier).HasColumnName("BSKIdentifier");
            this.Property(t => t.WebSiteOrderNumber).HasColumnName("WebSiteOrderNumber");
            this.Property(t => t.PaymentTermsCode).HasColumnName("PaymentTermsCode");
            this.Property(t => t.PaymentInstrument).HasColumnName("PaymentInstrument");
            this.Property(t => t.BackOrdersAllowed).HasColumnName("BackOrdersAllowed");
            this.Property(t => t.RouteCode).HasColumnName("RouteCode");
            this.Property(t => t.HoldCode).HasColumnName("HoldCode");
            this.Property(t => t.SoldToCustomerID).HasColumnName("SoldToCustomerID");
            this.Property(t => t.HoldOrder).HasColumnName("HoldOrder");
            this.Property(t => t.OrderType).HasColumnName("OrderType");
            this.Property(t => t.OrderLanguageCode).HasColumnName("OrderLanguageCode");
            this.Property(t => t.PhysicalIdentifier).HasColumnName("PhysicalIdentifier");
            this.Property(t => t.OriginatingStoreIdentifier).HasColumnName("OriginatingStoreIdentifier");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.ShipToCustomerID);
            this.HasOptional(t => t.Customer1)
                .WithMany(t => t.Orders1)
                .HasForeignKey(d => d.SoldToCustomerID);

        }
    }
}
