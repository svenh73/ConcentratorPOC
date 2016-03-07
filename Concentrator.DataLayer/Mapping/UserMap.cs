using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(1024);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Firstname)
                .HasMaxLength(255);

            this.Property(t => t.Lastname)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Lastname).HasColumnName("Lastname");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
