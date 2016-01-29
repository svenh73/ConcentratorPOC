using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class SlurpQueueMap : EntityTypeConfiguration<SlurpQueue>
    {
        public SlurpQueueMap()
        {
            // Primary Key
            this.HasKey(t => t.QueueID);

            // Properties
            // Table & Column Mappings
            this.ToTable("SlurpQueue");
            this.Property(t => t.QueueID).HasColumnName("QueueID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductCompareSourceID).HasColumnName("ProductCompareSourceID");
            this.Property(t => t.SlurpScheduleID).HasColumnName("SlurpScheduleID");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.CompletionTime).HasColumnName("CompletionTime");
            this.Property(t => t.IsCompleted).HasColumnName("IsCompleted");
            this.Property(t => t.StartTime).HasColumnName("StartTime");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SlurpQueues)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.ProductCompareSource)
                .WithMany(t => t.SlurpQueues)
                .HasForeignKey(d => d.ProductCompareSourceID);
            this.HasOptional(t => t.SlurpSchedule)
                .WithMany(t => t.SlurpQueues)
                .HasForeignKey(d => d.SlurpScheduleID);

        }
    }
}
