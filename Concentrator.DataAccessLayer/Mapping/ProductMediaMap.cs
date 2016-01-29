using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductMediaMap : EntityTypeConfiguration<ProductMedia>
    {
        public ProductMediaMap()
        {
            // Primary Key
            this.HasKey(t => t.MediaID);

            // Properties
            this.Property(t => t.Resolution)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ProductMedia");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.MediaUrl).HasColumnName("MediaUrl");
            this.Property(t => t.MediaPath).HasColumnName("MediaPath");
            this.Property(t => t.MediaID).HasColumnName("MediaID");
            this.Property(t => t.Resolution).HasColumnName("Resolution");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.IsThumbNailImage).HasColumnName("IsThumbNailImage");
            this.Property(t => t.LastChanged).HasColumnName("LastChanged");

            // Relationships
            this.HasRequired(t => t.MediaType)
                .WithMany(t => t.ProductMedias)
                .HasForeignKey(d => d.TypeID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductMedias)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ProductMedias)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
