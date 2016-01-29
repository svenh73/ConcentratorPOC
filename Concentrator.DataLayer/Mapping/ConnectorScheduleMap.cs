using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorScheduleMap : EntityTypeConfiguration<ConnectorSchedule>
    {
        public ConnectorScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorScheduleID);

            // Properties
            this.Property(t => t.Duration)
                .HasMaxLength(50);

            this.Property(t => t.CronExpression)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ConnectorSchedule");
            this.Property(t => t.ConnectorScheduleID).HasColumnName("ConnectorScheduleID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.PluginID).HasColumnName("PluginID");
            this.Property(t => t.LastRun).HasColumnName("LastRun");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.ScheduledNextRun).HasColumnName("ScheduledNextRun");
            this.Property(t => t.ConnectorScheduleStatus).HasColumnName("ConnectorScheduleStatus");
            this.Property(t => t.ExecuteOnStartup).HasColumnName("ExecuteOnStartup");
            this.Property(t => t.CronExpression).HasColumnName("CronExpression");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorSchedules)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Plugin)
                .WithMany(t => t.ConnectorSchedules)
                .HasForeignKey(d => d.PluginID);

        }
    }
}
