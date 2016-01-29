using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PaymentMethodDescriptionMap : EntityTypeConfiguration<PaymentMethodDescription>
    {
        public PaymentMethodDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PaymentMethodID, t.LanguageID });

            // Properties
            this.Property(t => t.PaymentMethodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("PaymentMethodDescription");
            this.Property(t => t.PaymentMethodID).HasColumnName("PaymentMethodID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.PaymentMethodDescriptions)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.PaymentMethod)
                .WithMany(t => t.PaymentMethodDescriptions)
                .HasForeignKey(d => d.PaymentMethodID);

        }
    }
}
