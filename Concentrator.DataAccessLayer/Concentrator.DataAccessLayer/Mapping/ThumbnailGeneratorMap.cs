using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ThumbnailGeneratorMap : EntityTypeConfiguration<ThumbnailGenerator>
    {
        public ThumbnailGeneratorMap()
        {
            // Primary Key
            this.HasKey(t => t.ThumbnailGeneratorID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ThumbnailGenerator");
            this.Property(t => t.ThumbnailGeneratorID).HasColumnName("ThumbnailGeneratorID");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Resolution).HasColumnName("Resolution");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
        }
    }
}
