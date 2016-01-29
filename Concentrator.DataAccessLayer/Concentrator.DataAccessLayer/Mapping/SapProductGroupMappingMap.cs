using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SapProductGroupMappingMap : EntityTypeConfiguration<SapProductGroupMapping>
    {
        public SapProductGroupMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductGroupNumber);

            // Properties
            this.Property(t => t.ProductGroupNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SRP5)
                .HasMaxLength(50);

            this.Property(t => t.SRP2)
                .HasMaxLength(50);

            this.Property(t => t.SRP4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SapProductGroupMapping");
            this.Property(t => t.ProductGroupNumber).HasColumnName("ProductGroupNumber");
            this.Property(t => t.SRP5).HasColumnName("SRP5");
            this.Property(t => t.SRP2).HasColumnName("SRP2");
            this.Property(t => t.SRP4).HasColumnName("SRP4");
        }
    }
}
