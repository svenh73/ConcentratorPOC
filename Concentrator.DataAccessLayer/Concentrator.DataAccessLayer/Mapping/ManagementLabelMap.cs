using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ManagementLabelMap : EntityTypeConfiguration<ManagementLabel>
    {
        public ManagementLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagementLabelID);

            // Properties
            this.Property(t => t.Field)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Label)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Grid)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ManagementLabel");
            this.Property(t => t.ManagementLabelID).HasColumnName("ManagementLabelID");
            this.Property(t => t.Field).HasColumnName("Field");
            this.Property(t => t.Label).HasColumnName("Label");
            this.Property(t => t.Grid).HasColumnName("Grid");
            this.Property(t => t.UserID).HasColumnName("UserID");
        }
    }
}
