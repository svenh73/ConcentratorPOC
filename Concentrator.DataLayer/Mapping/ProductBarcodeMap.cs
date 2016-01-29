using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductBarcodeMap : EntityTypeConfiguration<ProductBarcode>
    {
        public ProductBarcodeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.Barcode });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Barcode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductBarcode");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.BarcodeType).HasColumnName("BarcodeType");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductBarcodes)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.ProductBarcodes)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
