using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConfigMap : EntityTypeConfiguration<Config>
    {
        public ConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Name, t.Value });

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Config");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
