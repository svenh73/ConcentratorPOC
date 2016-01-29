using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorTranslationTypeMap : EntityTypeConfiguration<VendorTranslationType>
    {
        public VendorTranslationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorTranslationType1);

            // Properties
            this.Property(t => t.VendorTranslationType1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorTranslationDescription)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("VendorTranslationTypes");
            this.Property(t => t.VendorTranslationType1).HasColumnName("VendorTranslationType");
            this.Property(t => t.VendorTranslationDescription).HasColumnName("VendorTranslationDescription");
        }
    }
}
