using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PortalNotificationMap : EntityTypeConfiguration<PortalNotification>
    {
        public PortalNotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.FormID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Priority)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ArticleNumber)
                .IsRequired();

            this.Property(t => t.ProductName)
                .IsRequired();

            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("PortalNotification");
            this.Property(t => t.FormID).HasColumnName("FormID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Priority).HasColumnName("Priority");
            this.Property(t => t.ArticleNumber).HasColumnName("ArticleNumber");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.NotificationType).HasColumnName("NotificationType");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.IsResolved).HasColumnName("IsResolved");
        }
    }
}
