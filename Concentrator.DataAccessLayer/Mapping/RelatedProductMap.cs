using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RelatedProductMap : EntityTypeConfiguration<RelatedProduct>
    {
        public RelatedProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.RelatedProductID, t.VendorID, t.RelatedProductTypeID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RelatedProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RelatedProductTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RelatedProduct");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.RelatedProductID).HasColumnName("RelatedProductID");
            this.Property(t => t.Preferred).HasColumnName("Preferred");
            this.Property(t => t.Reversed).HasColumnName("Reversed");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.RelatedProductTypeID).HasColumnName("RelatedProductTypeID");
            this.Property(t => t.IsConfigured).HasColumnName("IsConfigured");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.MarkedForDeletion).HasColumnName("MarkedForDeletion");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.RelatedProducts)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Product1)
                .WithMany(t => t.RelatedProducts1)
                .HasForeignKey(d => d.RelatedProductID);
            this.HasRequired(t => t.RelatedProductType)
                .WithMany(t => t.RelatedProducts)
                .HasForeignKey(d => d.RelatedProductTypeID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.RelatedProducts)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.RelatedProducts1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.RelatedProducts)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
