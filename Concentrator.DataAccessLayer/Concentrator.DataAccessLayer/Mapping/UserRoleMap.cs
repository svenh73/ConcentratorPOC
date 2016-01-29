using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.RoleID, t.VendorID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserRole");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.RoleID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
