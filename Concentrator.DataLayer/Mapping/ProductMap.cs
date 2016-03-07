using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BrandId).HasColumnName("BrandId");
            this.Property(t => t.ProductTypeId).HasColumnName("ProductTypeId");
            this.Property(t => t.ProductGroupId).HasColumnName("ProductGroupId");
            this.Property(t => t.ParentProductId).HasColumnName("ParentProductId");
            this.Property(t => t.DateTimeCreated).HasColumnName("DateTimeCreated");
            this.Property(t => t.DateTimeLastModified).HasColumnName("DateTimeLastModified");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.BrandId);
            this.HasOptional(t => t.Product2)
                .WithMany(t => t.Product1)
                .HasForeignKey(d => d.ParentProductId);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductGroupId);
          this.HasRequired(t => t.ProductType)
            .WithMany(t => t.Products)
            .HasForeignKey(d => d.ProductTypeId);

          this.HasIndex("IX_BrandId", e => e.Property(x => x.BrandId));

        }
    }
}
