using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Event");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.ProcessName).HasColumnName("ProcessName");
            this.Property(t => t.ExceptionMessage).HasColumnName("ExceptionMessage");
            this.Property(t => t.StackTrace).HasColumnName("StackTrace");
            this.Property(t => t.ExceptionLocation).HasColumnName("ExceptionLocation");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.PluginID).HasColumnName("PluginID");
            this.Property(t => t.Notified).HasColumnName("Notified");

            // Relationships
            this.HasRequired(t => t.EventType)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.TypeID);
            this.HasOptional(t => t.Plugin)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.PluginID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Events1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);

        }
    }
}
