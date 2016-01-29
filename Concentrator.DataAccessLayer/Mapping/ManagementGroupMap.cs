using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ManagementGroupMap : EntityTypeConfiguration<ManagementGroup>
    {
        public ManagementGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupID);

            // Properties
            this.Property(t => t.Group)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DashboardName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ManagementGroup");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.Group).HasColumnName("Group");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.DashboardName).HasColumnName("DashboardName");

            // Relationships
            this.HasOptional(t => t.Portal)
                .WithMany(t => t.ManagementGroups)
                .HasForeignKey(d => d.PortalID);

        }
    }
}
