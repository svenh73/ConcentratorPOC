using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserPortalMap : EntityTypeConfiguration<UserPortal>
    {
        public UserPortalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PortalID, t.UserID });

            // Properties
            this.Property(t => t.PortalID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserPortal");
            this.Property(t => t.PortalID).HasColumnName("PortalID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.West).HasColumnName("West");
            this.Property(t => t.East).HasColumnName("East");

            // Relationships
            this.HasRequired(t => t.Portal)
                .WithMany(t => t.UserPortals)
                .HasForeignKey(d => d.PortalID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserPortals)
                .HasForeignKey(d => d.UserID);

        }
    }
}
