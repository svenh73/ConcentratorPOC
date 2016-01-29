using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductImageMap : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ImageID, t.ProductID, t.Sequence, t.VendorID });

            // Properties
            this.Property(t => t.ImageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ImagePath)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductImage");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductImages)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductImages)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
