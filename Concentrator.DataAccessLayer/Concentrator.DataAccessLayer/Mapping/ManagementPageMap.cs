using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ManagementPageMap : EntityTypeConfiguration<ManagementPage>
    {
        public ManagementPageMap()
        {
            // Primary Key
            this.HasKey(t => t.PageID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.JSAction)
                .IsRequired();

            this.Property(t => t.Icon)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasMaxLength(50);

            this.Property(t => t.FunctionalityName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ManagementPage");
            this.Property(t => t.PageID).HasColumnName("PageID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.JSAction).HasColumnName("JSAction");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.isVisible).HasColumnName("isVisible");
            this.Property(t => t.FunctionalityName).HasColumnName("FunctionalityName");

            // Relationships
            this.HasOptional(t => t.ManagementGroup)
                .WithMany(t => t.ManagementPages)
                .HasForeignKey(d => d.GroupID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.ManagementPages)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
