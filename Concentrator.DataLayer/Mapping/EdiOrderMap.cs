using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderMap : EntityTypeConfiguration<EdiOrder>
    {
        public EdiOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderID);

            // Properties
            this.Property(t => t.EdiVersion)
                .HasMaxLength(50);

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

            // Table & Column Mappings
            this.ToTable("EdiOrder");
            this.Property(t => t.EdiOrderID).HasColumnName("EdiOrderID");
            this.Property(t => t.EdiRequestID).HasColumnName("EdiRequestID");
            this.Property(t => t.Document).HasColumnName("Document");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.IsDispatched).HasColumnName("IsDispatched");
            this.Property(t => t.DispatchToVendorDate).HasColumnName("DispatchToVendorDate");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
            this.Property(t => t.isDropShipment).HasColumnName("isDropShipment");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ShipToCustomerID).HasColumnName("ShipToCustomerID");
            this.Property(t => t.SoldToCustomerID).HasColumnName("SoldToCustomerID");
            this.Property(t => t.CustomerOrderReference).HasColumnName("CustomerOrderReference");
            this.Property(t => t.EdiVersion).HasColumnName("EdiVersion");
            this.Property(t => t.BSKIdentifier).HasColumnName("BSKIdentifier");
            this.Property(t => t.WebSiteOrderNumber).HasColumnName("WebSiteOrderNumber");
            this.Property(t => t.PaymentTermsCode).HasColumnName("PaymentTermsCode");
            this.Property(t => t.PaymentInstrument).HasColumnName("PaymentInstrument");
            this.Property(t => t.BackOrdersAllowed).HasColumnName("BackOrdersAllowed");
            this.Property(t => t.RouteCode).HasColumnName("RouteCode");
            this.Property(t => t.HoldCode).HasColumnName("HoldCode");
            this.Property(t => t.HoldOrder).HasColumnName("HoldOrder");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.EdiOrderTypeID).HasColumnName("EdiOrderTypeID");
            this.Property(t => t.PartialDelivery).HasColumnName("PartialDelivery");
            this.Property(t => t.ConnectorRelationID).HasColumnName("ConnectorRelationID");
            this.Property(t => t.RequestDate).HasColumnName("RequestDate");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.EdiOrders)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.ConnectorRelation)
                .WithMany(t => t.EdiOrders)
                .HasForeignKey(d => d.ConnectorRelationID);
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.EdiOrders)
                .HasForeignKey(d => d.ShipToCustomerID);
            this.HasOptional(t => t.Customer1)
                .WithMany(t => t.EdiOrders1)
                .HasForeignKey(d => d.SoldToCustomerID);
            this.HasRequired(t => t.EdiOrderListener)
                .WithMany(t => t.EdiOrders)
                .HasForeignKey(d => d.EdiRequestID);
            this.HasRequired(t => t.EdiOrderType)
                .WithMany(t => t.EdiOrders)
                .HasForeignKey(d => d.EdiOrderTypeID);

        }
    }
}
