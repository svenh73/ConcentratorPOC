using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SearchContentMap : EntityTypeConfiguration<SearchContent>
    {
        public SearchContentMap()
        {
            // Primary Key
            this.HasKey(t => t.SearchContentID);

            // Properties
            this.Property(t => t.VendorItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.BrandName)
                .HasMaxLength(150);

            this.Property(t => t.Barcode)
                .HasMaxLength(50);

            this.Property(t => t.ProductName)
                .HasMaxLength(150);

            this.Property(t => t.ModelName)
                .HasMaxLength(150);

            this.Property(t => t.CustomItemNumber)
                .HasMaxLength(150);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(150);

            this.Property(t => t.LongDescription)
                .HasMaxLength(900);

            this.Property(t => t.ImagePath)
                .HasMaxLength(255);

            this.Property(t => t.ShortContentDescription)
                .HasMaxLength(900);

            this.Property(t => t.SearchText)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("SearchContent");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ModelName).HasColumnName("ModelName");
            this.Property(t => t.CustomItemNumber).HasColumnName("CustomItemNumber");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.ShortContentDescription).HasColumnName("ShortContentDescription");
            this.Property(t => t.SearchText).HasColumnName("SearchText");
            this.Property(t => t.SearchContentID).HasColumnName("SearchContentID");
        }
    }
}
