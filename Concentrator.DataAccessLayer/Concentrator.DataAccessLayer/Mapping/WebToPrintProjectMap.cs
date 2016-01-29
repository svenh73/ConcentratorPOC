using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintProjectMap : EntityTypeConfiguration<WebToPrintProject>
    {
        public WebToPrintProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("WebToPrintProject");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.WebToPrintProjects)
                .HasForeignKey(d => d.UserID);

        }
    }
}
