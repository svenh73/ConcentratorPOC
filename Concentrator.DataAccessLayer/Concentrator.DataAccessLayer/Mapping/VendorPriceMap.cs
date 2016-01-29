using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorPriceMap : EntityTypeConfiguration<VendorPrice>
    {
        public VendorPriceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorAssortmentID, t.MinimumQuantity });

            // Properties
            this.Property(t => t.VendorAssortmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MinimumQuantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CommercialStatus)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorPrice");
            this.Property(t => t.VendorAssortmentID).HasColumnName("VendorAssortmentID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.CommercialStatus).HasColumnName("CommercialStatus");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.BaseCostPrice).HasColumnName("BaseCostPrice");
            this.Property(t => t.VendorPriceRuleID).HasColumnName("VendorPriceRuleID");
            this.Property(t => t.SpecialPrice).HasColumnName("SpecialPrice");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");

            // Relationships
            this.HasOptional(t => t.AssortmentStatus)
                .WithMany(t => t.VendorPrices)
                .HasForeignKey(d => d.ConcentratorStatusID);
            this.HasRequired(t => t.VendorAssortment)
                .WithMany(t => t.VendorPrices)
                .HasForeignKey(d => d.VendorAssortmentID);
            this.HasOptional(t => t.VendorPriceRule)
                .WithMany(t => t.VendorPrices)
                .HasForeignKey(d => d.VendorPriceRuleID);

        }
    }
}
