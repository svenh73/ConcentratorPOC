using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorLanguageMap : EntityTypeConfiguration<ConnectorLanguage>
    {
        public ConnectorLanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorLanguageID);

            // Properties
            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("ConnectorLanguage");
            this.Property(t => t.ConnectorLanguageID).HasColumnName("ConnectorLanguageID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Country).HasColumnName("Country");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorLanguages)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ConnectorLanguages)
                .HasForeignKey(d => d.LanguageID);

        }
    }
}
