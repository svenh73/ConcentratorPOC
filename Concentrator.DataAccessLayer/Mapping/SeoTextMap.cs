using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SeoTextMap : EntityTypeConfiguration<SeoText>
    {
        public SeoTextMap()
        {
            // Primary Key
            this.HasKey(t => t.SeoTextID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SeoTexts");
            this.Property(t => t.SeoTextID).HasColumnName("SeoTextID");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DescriptionType).HasColumnName("DescriptionType");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");

            // Relationships
            this.HasRequired(t => t.Language)
                .WithMany(t => t.SeoTexts)
                .HasForeignKey(d => d.LanguageID);

        }
    }
}
