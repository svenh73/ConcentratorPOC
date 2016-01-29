using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorSystemMap : EntityTypeConfiguration<ConnectorSystem>
    {
        public ConnectorSystemMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorSystemID);

            // Properties
            this.Property(t => t.ConnectorSystemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConnectorSystem");
            this.Property(t => t.ConnectorSystemID).HasColumnName("ConnectorSystemID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
