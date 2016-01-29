using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorSettingMap : EntityTypeConfiguration<ConnectorSetting>
    {
        public ConnectorSettingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConnectorID, t.SettingKey });

            // Properties
            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SettingKey)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ConnectorSetting");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.SettingKey).HasColumnName("SettingKey");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorSettings)
                .HasForeignKey(d => d.ConnectorID);

        }
    }
}
