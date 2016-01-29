using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserStateMap : EntityTypeConfiguration<UserState>
    {
        public UserStateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateID);

            // Properties
            this.Property(t => t.EntityName)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.SavedState)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("UserState");
            this.Property(t => t.StateID).HasColumnName("StateID");
            this.Property(t => t.EntityName).HasColumnName("EntityName");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.SavedState).HasColumnName("SavedState");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserStates)
                .HasForeignKey(d => d.UserID);

        }
    }
}
