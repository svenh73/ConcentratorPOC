using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintQueueMap : EntityTypeConfiguration<WebToPrintQueue>
    {
        public WebToPrintQueueMap()
        {
            // Primary Key
            this.HasKey(t => t.QueueID);

            // Properties
            this.Property(t => t.Data)
                .IsRequired();

            this.Property(t => t.Message)
                .HasMaxLength(512);

            // Table & Column Mappings
            this.ToTable("WebToPrintQueue");
            this.Property(t => t.QueueID).HasColumnName("QueueID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Message).HasColumnName("Message");

            // Relationships
            this.HasRequired(t => t.WebToPrintProject)
                .WithMany(t => t.WebToPrintQueues)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
