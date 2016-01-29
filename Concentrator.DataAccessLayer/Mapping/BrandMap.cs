using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(p => p.Test);
            this.Property(p => p.Test3);

            // Table & Column Mappings
            this.ToTable("Brand");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ParentBrandID).HasColumnName("ParentBrandID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Test2).HasColumnName("Test2");

            // Relationships
            this.HasOptional(t => t.Brand2)
                .WithMany(t => t.Brand1)
                .HasForeignKey(d => d.ParentBrandID);

        }
    }
}
