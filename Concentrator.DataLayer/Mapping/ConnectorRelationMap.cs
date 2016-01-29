using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorRelationMap : EntityTypeConfiguration<ConnectorRelation>
    {
        public ConnectorRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorRelationID);

            // Properties
            this.Property(t => t.CustomerID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OutboundTo)
                .HasMaxLength(100);

            this.Property(t => t.OutboundPassword)
                .HasMaxLength(100);

            this.Property(t => t.OutboundUsername)
                .HasMaxLength(100);

            this.Property(t => t.FtpAddress)
                .HasMaxLength(100);

            this.Property(t => t.FtpPass)
                .HasMaxLength(50);

            this.Property(t => t.Username)
                .HasMaxLength(500);

            this.Property(t => t.Password)
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Contact)
                .HasMaxLength(100);

            this.Property(t => t.OutboundOrderConfirmation)
                .HasMaxLength(100);

            this.Property(t => t.OutboundShipmentConfirmation)
                .HasMaxLength(100);

            this.Property(t => t.OutboundInvoiceConfirmation)
                .HasMaxLength(100);

            this.Property(t => t.AdministrationCode)
                .HasMaxLength(50);

            this.Property(t => t.OrderType)
                .HasMaxLength(50);

            this.Property(t => t.FreightProduct)
                .HasMaxLength(50);

            this.Property(t => t.FinChargesProduct)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ConnectorRelation");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.OrderConfirmation).HasColumnName("OrderConfirmation");
            this.Property(t => t.ShipmentConfirmation).HasColumnName("ShipmentConfirmation");
            this.Property(t => t.InvoiceConfirmation).HasColumnName("InvoiceConfirmation");
            this.Property(t => t.OutboundTo).HasColumnName("OutboundTo");
            this.Property(t => t.OutboundPassword).HasColumnName("OutboundPassword");
            this.Property(t => t.OutboundUsername).HasColumnName("OutboundUsername");
            this.Property(t => t.ConnectorType).HasColumnName("ConnectorType");
            this.Property(t => t.OutboundMessageType).HasColumnName("OutboundMessageType");
            this.Property(t => t.AuthorisationAddresses).HasColumnName("AuthorisationAddresses");
            this.Property(t => t.AccountPrivileges).HasColumnName("AccountPrivileges");
            this.Property(t => t.UseFtp).HasColumnName("UseFtp");
            this.Property(t => t.ProviderType).HasColumnName("ProviderType");
            this.Property(t => t.FtpType).HasColumnName("FtpType");
            this.Property(t => t.FtpFrequency).HasColumnName("FtpFrequency");
            this.Property(t => t.FtpAddress).HasColumnName("FtpAddress");
            this.Property(t => t.FtpPass).HasColumnName("FtpPass");
            this.Property(t => t.FtpPort).HasColumnName("FtpPort");
            this.Property(t => t.XtractType).HasColumnName("XtractType");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.FtpConnectionType).HasColumnName("FtpConnectionType");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.ConnectorRelationID).HasColumnName("ConnectorRelationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.OutboundOrderConfirmation).HasColumnName("OutboundOrderConfirmation");
            this.Property(t => t.OutboundShipmentConfirmation).HasColumnName("OutboundShipmentConfirmation");
            this.Property(t => t.OutboundInvoiceConfirmation).HasColumnName("OutboundInvoiceConfirmation");
            this.Property(t => t.AdministrationCode).HasColumnName("AdministrationCode");
            this.Property(t => t.OrderType).HasColumnName("OrderType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.EdiVendorID).HasColumnName("EdiVendorID");
            this.Property(t => t.FreightProduct).HasColumnName("FreightProduct");
            this.Property(t => t.FinChargesProduct).HasColumnName("FinChargesProduct");
            this.Property(t => t.Email).HasColumnName("Email");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ConnectorRelations)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.EdiVendor)
                .WithMany(t => t.ConnectorRelations)
                .HasForeignKey(d => d.EdiVendorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ConnectorRelations)
                .HasForeignKey(d => d.LanguageID);

        }
    }
}
