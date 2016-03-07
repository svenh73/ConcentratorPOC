using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class VendorProductMap : EntityTypeConfiguration<VendorProduct>
    {
        public VendorProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorIdentifier)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VendorProduct");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.VendorIdentifier).HasColumnName("VendorIdentifier");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.LastModified).HasColumnName("LastModified");
            this.Property(t => t.Created).HasColumnName("Created");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.VendorProducts)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
