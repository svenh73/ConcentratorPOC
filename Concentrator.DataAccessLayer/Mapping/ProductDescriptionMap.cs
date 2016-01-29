using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductDescriptionMap : EntityTypeConfiguration<ProductDescription>
    {
        public ProductDescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.LanguageID, t.VendorID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShortContentDescription)
                .HasMaxLength(1000);

            this.Property(t => t.LongContentDescription)
                .HasMaxLength(3500);

            this.Property(t => t.ShortSummaryDescription)
                .HasMaxLength(1000);

            this.Property(t => t.LongSummaryDescription)
                .HasMaxLength(3000);

            this.Property(t => t.PDFUrl)
                .HasMaxLength(500);

            this.Property(t => t.Url)
                .HasMaxLength(500);

            this.Property(t => t.WarrantyInfo)
                .HasMaxLength(2500);

            this.Property(t => t.ModelName)
                .HasMaxLength(300);

            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            this.Property(t => t.Quality)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("ProductDescription");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ShortContentDescription).HasColumnName("ShortContentDescription");
            this.Property(t => t.LongContentDescription).HasColumnName("LongContentDescription");
            this.Property(t => t.ShortSummaryDescription).HasColumnName("ShortSummaryDescription");
            this.Property(t => t.LongSummaryDescription).HasColumnName("LongSummaryDescription");
            this.Property(t => t.PDFUrl).HasColumnName("PDFUrl");
            this.Property(t => t.PDFSize).HasColumnName("PDFSize");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.WarrantyInfo).HasColumnName("WarrantyInfo");
            this.Property(t => t.ModelName).HasColumnName("ModelName");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.Quality).HasColumnName("Quality");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductDescriptions)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductDescriptions)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ProductDescriptions)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.ProductDescriptions1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductDescriptions)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
