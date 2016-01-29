using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SapProductGroupNumberMap : EntityTypeConfiguration<SapProductGroupNumber>
    {
        public SapProductGroupNumberMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SAPNumber, t.ProductGroupNumber });

            // Properties
            this.Property(t => t.SAPNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.GTin)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.ProductGroupNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SapProductGroupNumber");
            this.Property(t => t.SAPNumber).HasColumnName("SAPNumber");
            this.Property(t => t.GTin).HasColumnName("GTin");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ProductGroupNumber).HasColumnName("ProductGroupNumber");
        }
    }
}
