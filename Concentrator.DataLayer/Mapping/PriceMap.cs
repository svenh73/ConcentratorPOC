using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class PriceMap : EntityTypeConfiguration<Price>
    {
        public PriceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Price");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ChannelProductId).HasColumnName("ChannelProductId");
            this.Property(t => t.VatId).HasColumnName("VatId");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.PriceTypeId).HasColumnName("PriceTypeId");
            this.Property(t => t.VendorProductId).HasColumnName("VendorProductId");
            this.Property(t => t.Price1).HasColumnName("Price");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.IncludingVAT).HasColumnName("IncludingVAT");

            // Relationships
            this.HasRequired(t => t.ChannelProduct)
                .WithMany(t => t.Prices)
                .HasForeignKey(d => d.ChannelProductId);
            this.HasRequired(t => t.Currrency)
                .WithMany(t => t.Prices)
                .HasForeignKey(d => d.CurrencyId);
            this.HasRequired(t => t.PriceType)
                .WithMany(t => t.Prices)
                .HasForeignKey(d => d.PriceTypeId);
            this.HasRequired(t => t.VendorProduct)
                .WithMany(t => t.Prices)
                .HasForeignKey(d => d.VendorProductId);
            this.HasRequired(t => t.VAT)
                .WithMany(t => t.Prices)
                .HasForeignKey(d => d.VatId);

        }
    }
}
