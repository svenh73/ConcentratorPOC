using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class AssortmentStatusMap : EntityTypeConfiguration<AssortmentStatus>
    {
        public AssortmentStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusID);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AssortmentStatus");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
