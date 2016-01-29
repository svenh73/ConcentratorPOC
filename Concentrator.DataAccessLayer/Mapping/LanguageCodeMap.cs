using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class LanguageCodeMap : EntityTypeConfiguration<LanguageCode>
    {
        public LanguageCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.magentoWebsiteStoreCode)
                .HasMaxLength(20);

            this.Property(t => t.Lang)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("LanguageCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.connectorID).HasColumnName("connectorID");
            this.Property(t => t.magentoWebsiteStoreCode).HasColumnName("magentoWebsiteStoreCode");
            this.Property(t => t.Lang).HasColumnName("Lang");
        }
    }
}
