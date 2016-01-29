using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserDownloadMap : EntityTypeConfiguration<UserDownload>
    {
        public UserDownloadMap()
        {
            // Primary Key
            this.HasKey(t => t.DownloadID);

            // Properties
            this.Property(t => t.MediaPath)
                .IsRequired();

            this.Property(t => t.MediaName)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.ImageSize)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("UserDownload");
            this.Property(t => t.DownloadID).HasColumnName("DownloadID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.MediaType).HasColumnName("MediaType");
            this.Property(t => t.MediaPath).HasColumnName("MediaPath");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.IsProduct).HasColumnName("IsProduct");
            this.Property(t => t.MediaName).HasColumnName("MediaName");
            this.Property(t => t.ImageSize).HasColumnName("ImageSize");

            // Relationships
            this.HasRequired(t => t.MediaType1)
                .WithMany(t => t.UserDownloads)
                .HasForeignKey(d => d.MediaType);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserDownloads)
                .HasForeignKey(d => d.UserID);

        }
    }
}
