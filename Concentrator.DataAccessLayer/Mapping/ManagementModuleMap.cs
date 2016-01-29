using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ManagementModuleMap : EntityTypeConfiguration<ManagementModule>
    {
        public ManagementModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ModuleID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IconClass)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ManagementModule");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IconClass).HasColumnName("IconClass");
        }
    }
}
