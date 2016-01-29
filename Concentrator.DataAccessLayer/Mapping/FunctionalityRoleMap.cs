using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class FunctionalityRoleMap : EntityTypeConfiguration<FunctionalityRole>
    {
        public FunctionalityRoleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoleID, t.FunctionalityName });

            // Properties
            this.Property(t => t.RoleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FunctionalityName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FunctionalityRole");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.FunctionalityName).HasColumnName("FunctionalityName");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.FunctionalityRoles)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
