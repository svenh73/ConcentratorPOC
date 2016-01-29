using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ManagementModuleItemMap : EntityTypeConfiguration<ManagementModuleItem>
    {
        public ManagementModuleItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagementModuleItemID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IconClass)
                .HasMaxLength(50);

            this.Property(t => t.JSAction)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ManagementModuleItem");
            this.Property(t => t.ManagementModuleItemID).HasColumnName("ManagementModuleItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.IconClass).HasColumnName("IconClass");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.JSAction).HasColumnName("JSAction");

            // Relationships
            this.HasRequired(t => t.ManagementModule)
                .WithMany(t => t.ManagementModuleItems)
                .HasForeignKey(d => d.ModuleID);

        }
    }
}
