using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SlurpScheduleMap : EntityTypeConfiguration<SlurpSchedule>
    {
        public SlurpScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.SlurpScheduleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SlurpSchedule");
            this.Property(t => t.SlurpScheduleID).HasColumnName("SlurpScheduleID");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Interval).HasColumnName("Interval");
            this.Property(t => t.IntervalType).HasColumnName("IntervalType");

            // Relationships
            this.HasOptional(t => t.Product)
                .WithMany(t => t.SlurpSchedules)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.ProductCompareSource)
                .WithMany(t => t.SlurpSchedules)
                .HasForeignKey(d => d.ProductCompareSourceID);
            this.HasOptional(t => t.ProductGroupMapping)
                .WithMany(t => t.SlurpSchedules)
                .HasForeignKey(d => d.ProductGroupMappingID);

        }
    }
}
