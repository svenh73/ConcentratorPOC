using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PluginMap : EntityTypeConfiguration<Plugin>
    {
        public PluginMap()
        {
            // Primary Key
            this.HasKey(t => t.PluginID);

            // Properties
            this.Property(t => t.PluginName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PluginType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PluginGroup)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CronExpression)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Duration)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Plugin");
            this.Property(t => t.PluginID).HasColumnName("PluginID");
            this.Property(t => t.PluginName).HasColumnName("PluginName");
            this.Property(t => t.PluginType).HasColumnName("PluginType");
            this.Property(t => t.PluginGroup).HasColumnName("PluginGroup");
            this.Property(t => t.CronExpression).HasColumnName("CronExpression");
            this.Property(t => t.ExecuteOnStartup).HasColumnName("ExecuteOnStartup");
            this.Property(t => t.LastRun).HasColumnName("LastRun");
            this.Property(t => t.NextRun).HasColumnName("NextRun");
            this.Property(t => t.Duration).HasColumnName("Duration");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.JobServer).HasColumnName("JobServer");
        }
    }
}
