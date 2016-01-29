using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserPluginMap : EntityTypeConfiguration<UserPlugin>
    {
        public UserPluginMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.PluginID, t.TypeID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PluginID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserPlugin");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PluginID).HasColumnName("PluginID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.SubscriptionTime).HasColumnName("SubscriptionTime");

            // Relationships
            this.HasRequired(t => t.EventType)
                .WithMany(t => t.UserPlugins)
                .HasForeignKey(d => d.TypeID);
            this.HasRequired(t => t.Plugin)
                .WithMany(t => t.UserPlugins)
                .HasForeignKey(d => d.PluginID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserPlugins)
                .HasForeignKey(d => d.UserID);

        }
    }
}
