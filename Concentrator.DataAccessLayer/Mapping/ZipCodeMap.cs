using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ZipCodeMap : EntityTypeConfiguration<ZipCode>
    {
        public ZipCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ZipCodeID);

            // Properties
            this.Property(t => t.PCWIJK)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.PCLETTER)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.PCREEKSID)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PCCITYTPG)
                .HasMaxLength(18);

            this.Property(t => t.PCCITYNEN)
                .HasMaxLength(24);

            this.Property(t => t.PCSTRTPG)
                .HasMaxLength(17);

            this.Property(t => t.PCSTRNEN)
                .HasMaxLength(24);

            this.Property(t => t.PCSTROFF)
                .HasMaxLength(43);

            this.Property(t => t.PCCITYEXT)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.PCSTREXT)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.PCGEMEENTENAAM)
                .HasMaxLength(24);

            this.Property(t => t.PCPROVINCIE)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ZipCode");
            this.Property(t => t.ZipCodeID).HasColumnName("ZipCodeID");
            this.Property(t => t.PCWIJK).HasColumnName("PCWIJK");
            this.Property(t => t.PCLETTER).HasColumnName("PCLETTER");
            this.Property(t => t.PCREEKSID).HasColumnName("PCREEKSID");
            this.Property(t => t.PCREEKSVAN).HasColumnName("PCREEKSVAN");
            this.Property(t => t.PCREEKSTOT).HasColumnName("PCREEKSTOT");
            this.Property(t => t.PCCITYTPG).HasColumnName("PCCITYTPG");
            this.Property(t => t.PCCITYNEN).HasColumnName("PCCITYNEN");
            this.Property(t => t.PCSTRTPG).HasColumnName("PCSTRTPG");
            this.Property(t => t.PCSTRNEN).HasColumnName("PCSTRNEN");
            this.Property(t => t.PCSTROFF).HasColumnName("PCSTROFF");
            this.Property(t => t.PCCITYEXT).HasColumnName("PCCITYEXT");
            this.Property(t => t.PCSTREXT).HasColumnName("PCSTREXT");
            this.Property(t => t.PCGEMEENTEID).HasColumnName("PCGEMEENTEID");
            this.Property(t => t.PCGEMEENTENAAM).HasColumnName("PCGEMEENTENAAM");
            this.Property(t => t.PCPROVINCIE).HasColumnName("PCPROVINCIE");
            this.Property(t => t.PCCEBUCO).HasColumnName("PCCEBUCO");
        }
    }
}
