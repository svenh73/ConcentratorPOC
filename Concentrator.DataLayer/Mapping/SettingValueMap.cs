using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class SettingValueMap : EntityTypeConfiguration<SettingValue>
    {
        public SettingValueMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Environment)
                .HasMaxLength(20);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("SettingValue");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ChannelId).HasColumnName("ChannelId");
            //this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.SettingId).HasColumnName("SettingId");
            this.Property(t => t.Environment).HasColumnName("Environment");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasOptional(t => t.Channel)
                .WithMany(t => t.SettingValues)
                .HasForeignKey(d => d.ChannelId);
            this.HasRequired(t => t.Setting)
                .WithMany(t => t.SettingValues)
                .HasForeignKey(d => d.SettingId);
            this.HasOptional(t => t.Task)
                .WithMany(t => t.SettingValues)
                .HasForeignKey(d => d.TaskId);

        }
    }
}
