using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PaymentProviderMap : EntityTypeConfiguration<PaymentProvider>
    {
        public PaymentProviderMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentProviderID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProviderType)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PaymentProvider");
            this.Property(t => t.PaymentProviderID).HasColumnName("PaymentProviderID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ProviderType).HasColumnName("ProviderType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
