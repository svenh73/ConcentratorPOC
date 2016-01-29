using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentFlatMap : EntityTypeConfiguration<ContentFlat>
    {
        public ContentFlatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConnectorID, t.ProductID, t.LanguageID });

            // Properties
            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorItemNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BrandName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorBrandCode)
                .HasMaxLength(150);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(255);

            this.Property(t => t.LongDescription)
                .HasMaxLength(255);

            this.Property(t => t.LineType)
                .HasMaxLength(50);

            this.Property(t => t.LedgerClass)
                .HasMaxLength(50);

            this.Property(t => t.ProductDesk)
                .HasMaxLength(50);

            this.Property(t => t.LongContentDescription)
                .HasMaxLength(3500);

            this.Property(t => t.ShortContentDescription)
                .HasMaxLength(1000);

            this.Property(t => t.ProductName)
                .HasMaxLength(255);

            this.Property(t => t.ModelName)
                .HasMaxLength(300);

            this.Property(t => t.WarrantyInfo)
                .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("ContentFlat");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.VendorBrandCode).HasColumnName("VendorBrandCode");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.LineType).HasColumnName("LineType");
            this.Property(t => t.LedgerClass).HasColumnName("LedgerClass");
            this.Property(t => t.ProductDesk).HasColumnName("ProductDesk");
            this.Property(t => t.ExtendedCatalog).HasColumnName("ExtendedCatalog");
            this.Property(t => t.ProductContentID).HasColumnName("ProductContentID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.LongContentDescription).HasColumnName("LongContentDescription");
            this.Property(t => t.ShortContentDescription).HasColumnName("ShortContentDescription");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ModelName).HasColumnName("ModelName");
            this.Property(t => t.WarrantyInfo).HasColumnName("WarrantyInfo");
            this.Property(t => t.CutOffTime).HasColumnName("CutOffTime");
            this.Property(t => t.DeliveryHours).HasColumnName("DeliveryHours");
        }
    }
}
