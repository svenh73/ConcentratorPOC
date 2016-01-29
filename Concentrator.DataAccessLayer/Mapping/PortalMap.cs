using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PortalMap : EntityTypeConfiguration<Portal>
    {
        public PortalMap()
        {
            // Primary Key
            this.HasKey(t => t.PortalID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Portal");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
