using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PortletMap : EntityTypeConfiguration<Portlet>
    {
        public PortletMap()
        {
            // Primary Key
            this.HasKey(t => t.PortletID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Portlet");
            this.Property(t => t.PortletID).HasColumnName("PortletID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasMany(t => t.Roles)
                .WithMany(t => t.Portlets)
                .Map(m =>
                    {
                        m.ToTable("PortletRole");
                        m.MapLeftKey("PortletID");
                        m.MapRightKey("RoleID");
                    });


        }
    }
}
