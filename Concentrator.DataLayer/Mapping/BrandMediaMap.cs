using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class BrandMediaMap : EntityTypeConfiguration<BrandMedia>
    {
        public BrandMediaMap()
        {
            // Primary Key
            this.HasKey(t => t.MediaID);

            // Properties
            this.Property(t => t.Resolution)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("BrandMedia");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.MediaUrl).HasColumnName("MediaUrl");
            this.Property(t => t.MediaPath).HasColumnName("MediaPath");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.Resolution).HasColumnName("Resolution");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandMedias)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.MediaType)
                .WithMany(t => t.BrandMedias)
                .HasForeignKey(d => d.TypeID);

        }
    }
}
