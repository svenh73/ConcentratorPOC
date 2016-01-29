using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductControlMap : EntityTypeConfiguration<ProductControl>
    {
        public ProductControlMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductControlID);

            // Properties
            this.Property(t => t.ProductControlID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductControlName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ProductControlDescription)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ProductControl");
            this.Property(t => t.ProductControlID).HasColumnName("ProductControlID");
            this.Property(t => t.ProductControlName).HasColumnName("ProductControlName");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ProductControlDescription).HasColumnName("ProductControlDescription");
        }
    }
}
