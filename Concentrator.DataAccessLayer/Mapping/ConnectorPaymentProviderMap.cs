using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorPaymentProviderMap : EntityTypeConfiguration<ConnectorPaymentProvider>
    {
        public ConnectorPaymentProviderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConnectorID, t.PaymentProviderID });

            // Properties
            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PaymentProviderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PaymentTermsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentInstrument)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConnectorPaymentProvider");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.PaymentProviderID).HasColumnName("PaymentProviderID");
            this.Property(t => t.PaymentTermsCode).HasColumnName("PaymentTermsCode");
            this.Property(t => t.PaymentInstrument).HasColumnName("PaymentInstrument");
            this.Property(t => t.Portfolio).HasColumnName("Portfolio");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Password).HasColumnName("Password");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorPaymentProviders)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.PaymentProvider)
                .WithMany(t => t.ConnectorPaymentProviders)
                .HasForeignKey(d => d.PaymentProviderID);

        }
    }
}
