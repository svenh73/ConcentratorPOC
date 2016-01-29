using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ImageStoreMap : EntityTypeConfiguration<ImageStore>
    {
        public ImageStoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ImageID);

            // Properties
            this.Property(t => t.ImageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ManufacturerID)
                .HasMaxLength(50);

            this.Property(t => t.ImageUrl)
                .HasMaxLength(255);

            this.Property(t => t.CustomerProductID)
                .HasMaxLength(50);

            this.Property(t => t.ImageType)
                .HasMaxLength(50);

            this.Property(t => t.BrandCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImageStore");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.ManufacturerID).HasColumnName("ManufacturerID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.CustomerProductID).HasColumnName("CustomerProductID");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.ImageType).HasColumnName("ImageType");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.BrandCode).HasColumnName("BrandCode");
            this.Property(t => t.ConcentratorProductID).HasColumnName("ConcentratorProductID");
        }
    }
}
