using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserID);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Firstname)
                .HasMaxLength(50);

            this.Property(t => t.Lastname)
                .HasMaxLength(50);

            this.Property(t => t.Logo)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Lastname).HasColumnName("Lastname");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Logo).HasColumnName("Logo");
            this.Property(t => t.Timeout).HasColumnName("Timeout");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");

            // Relationships
            this.HasMany(t => t.MasterGroupMappings)
                .WithMany(t => t.Users)
                .Map(m =>
                    {
                        m.ToTable("MasterGroupMappingUser");
                        m.MapLeftKey("UserID");
                        m.MapRightKey("MasterGroupMappingID");
                    });

            this.HasOptional(t => t.Connector)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.OrganizationID).WillCascadeOnDelete(false);

        }
    }
}
