using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorProductStatuMap : EntityTypeConfiguration<ConnectorProductStatu>
    {
        public ConnectorProductStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorProductStatusID);

            // Properties
            this.Property(t => t.ConnectorStatus)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConnectorProductStatus");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ConnectorStatus).HasColumnName("ConnectorStatus");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.ConnectorStatusID).HasColumnName("ConnectorStatusID");
            this.Property(t => t.ConnectorProductStatusID).HasColumnName("ConnectorProductStatusID");

            // Relationships
            this.HasRequired(t => t.AssortmentStatus)
                .WithMany(t => t.ConnectorProductStatus)
                .HasForeignKey(d => d.ConcentratorStatusID);

        }
    }
}
