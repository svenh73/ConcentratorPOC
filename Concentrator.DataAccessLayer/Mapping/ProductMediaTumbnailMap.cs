using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductMediaTumbnailMap : EntityTypeConfiguration<ProductMediaTumbnail>
    {
        public ProductMediaTumbnailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MediaID, t.ThumbnailGeneratorID });

            // Properties
            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ThumbnailGeneratorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Path)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ProductMediaTumbnail");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.ThumbnailGeneratorID).HasColumnName("ThumbnailGeneratorID");
            this.Property(t => t.Path).HasColumnName("Path");

            // Relationships
            this.HasRequired(t => t.ProductMedia)
                .WithMany(t => t.ProductMediaTumbnails)
                .HasForeignKey(d => d.MediaID);
            this.HasRequired(t => t.ThumbnailGenerator)
                .WithMany(t => t.ProductMediaTumbnails)
                .HasForeignKey(d => d.ThumbnailGeneratorID);

        }
    }
}
