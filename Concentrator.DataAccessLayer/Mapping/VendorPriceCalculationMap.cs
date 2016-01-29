using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorPriceCalculationMap : EntityTypeConfiguration<VendorPriceCalculation>
    {
        public VendorPriceCalculationMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorPriceCalculationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Calculation)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VendorPriceCalculation");
            this.Property(t => t.VendorPriceCalculationID).HasColumnName("VendorPriceCalculationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
        }
    }
}
