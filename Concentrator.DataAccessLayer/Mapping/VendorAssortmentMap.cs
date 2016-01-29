using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorAssortmentMap : EntityTypeConfiguration<VendorAssortment>
    {
        public VendorAssortmentMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorAssortmentID);

            // Properties
            this.Property(t => t.CustomItemNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(150);

            this.Property(t => t.LongDescription)
                .HasMaxLength(1000);

            this.Property(t => t.LineType)
                .HasMaxLength(10);

            this.Property(t => t.LedgerClass)
                .HasMaxLength(50);

            this.Property(t => t.ProductDesk)
                .HasMaxLength(150);

            this.Property(t => t.ActivationKey)
                .HasMaxLength(255);

            this.Property(t => t.ZoneReferenceID)
                .HasMaxLength(255);

            this.Property(t => t.ShipmentRateTableReferenceID)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VendorAssortment");
            this.Property(t => t.VendorAssortmentID).HasColumnName("VendorAssortmentID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CustomItemNumber).HasColumnName("CustomItemNumber");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.LineType).HasColumnName("LineType");
            this.Property(t => t.LedgerClass).HasColumnName("LedgerClass");
            this.Property(t => t.ExtendedCatalog).HasColumnName("ExtendedCatalog");
            this.Property(t => t.ProductDesk).HasColumnName("ProductDesk");
            this.Property(t => t.ActivationKey).HasColumnName("ActivationKey");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ZoneReferenceID).HasColumnName("ZoneReferenceID");
            this.Property(t => t.ShipmentRateTableReferenceID).HasColumnName("ShipmentRateTableReferenceID");

            // Relationships
            this.HasMany(t => t.ProductGroupVendors)
                .WithMany(t => t.VendorAssortments)
                .Map(m =>
                    {
                        m.ToTable("VendorProductGroupAssortment");
                        m.MapLeftKey("VendorAssortmentID");
                        m.MapRightKey("ProductGroupVendorID");
                    });

            this.HasRequired(t => t.Product)
                .WithMany(t => t.VendorAssortments)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorAssortments)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
