using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MissingContentMap : EntityTypeConfiguration<MissingContent>
    {
        public MissingContentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConcentratorProductID, t.ConnectorID, t.ProductGroupID });

            // Properties
            this.Property(t => t.ConcentratorProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorItemNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CustomItemNumber)
                .HasMaxLength(50);

            this.Property(t => t.BrandName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(255);

            this.Property(t => t.ProductGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ContentVendor)
                .HasMaxLength(50);

            this.Property(t => t.Barcode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MissingContent");
            this.Property(t => t.ConcentratorProductID).HasColumnName("ConcentratorProductID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.isActive).HasColumnName("isActive");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.CustomItemNumber).HasColumnName("CustomItemNumber");
            this.Property(t => t.BrandName).HasColumnName("BrandName");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.YouTube).HasColumnName("YouTube");
            this.Property(t => t.Specifications).HasColumnName("Specifications");
            this.Property(t => t.ContentVendor).HasColumnName("ContentVendor");
            this.Property(t => t.ContentVendorID).HasColumnName("ContentVendorID");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.IsConfigurable).HasColumnName("IsConfigurable");
            this.Property(t => t.HasDescription).HasColumnName("HasDescription");
            this.Property(t => t.QuantityOnHand).HasColumnName("QuantityOnHand");
            this.Property(t => t.HasFrDescription).HasColumnName("HasFrDescription");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.MissingContents)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.MissingContents)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MissingContents)
                .HasForeignKey(d => d.ConcentratorProductID);

        }
    }
}
