using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class BarcodeMap : EntityTypeConfiguration<Barcode>
    {
        public BarcodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Barcode1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Barcode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.BarcodeTypeId).HasColumnName("BarcodeTypeId");
            this.Property(t => t.Barcode1).HasColumnName("Barcode");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastModified).HasColumnName("LastModified");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.Barcodes)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.BarcodeType)
                .WithMany(t => t.Barcodes)
                .HasForeignKey(d => d.BarcodeTypeId);

        }
    }
}
