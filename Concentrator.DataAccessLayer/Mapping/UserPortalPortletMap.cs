using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserPortalPortletMap : EntityTypeConfiguration<UserPortalPortlet>
    {
        public UserPortalPortletMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.PortalID, t.PortletID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PortalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PortletID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserPortalPortlet");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.PortletID).HasColumnName("PortletID");
            this.Property(t => t.Column).HasColumnName("Column");
            this.Property(t => t.Row).HasColumnName("Row");

            // Relationships
            this.HasRequired(t => t.Portlet)
                .WithMany(t => t.UserPortalPortlets)
                .HasForeignKey(d => d.PortletID);
            this.HasRequired(t => t.UserPortal)
                .WithMany(t => t.UserPortalPortlets)
                .HasForeignKey(d => new { d.PortalID, d.UserID });

        }
    }
}
