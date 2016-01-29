using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.VendorItemNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.SourceVendorID).HasColumnName("SourceVendorID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.IsConfigurable).HasColumnName("IsConfigurable");
            this.Property(t => t.IsNonAssortmentItem).HasColumnName("IsNonAssortmentItem");
            this.Property(t => t.ParentProductID).HasColumnName("ParentProductID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.IsBlocked).HasColumnName("IsBlocked");

            // Relationships
            this.HasMany(t => t.ProductAttributeMetaDatas)
                .WithMany(t => t.Products)
                .Map(m =>
                    {
                        m.ToTable("ProductAttributeConfiguration");
                        m.MapLeftKey("ProductID");
                        m.MapRightKey("AttributeID");
                    });

            //this.HasRequired(t => t.Brand)
            //    .WithMany(t => t.Products)
            //    .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Products1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.Product2)
                .WithMany(t => t.Product1)
                .HasForeignKey(d => d.ParentProductID);

        }
    }
}
