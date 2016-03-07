using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class ProductGroupMap : EntityTypeConfiguration<ProductGroup>
    {
        public ProductGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductGroup");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductGroupId).HasColumnName("ProductGroupId");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasOptional(t => t.ProductGroup2)
                .WithMany(t => t.ProductGroup1)
                .HasForeignKey(d => d.ProductGroupId);

        }
    }
}
