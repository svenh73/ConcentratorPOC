using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class productmedia_backupMap : EntityTypeConfiguration<productmedia_backup>
    {
        public productmedia_backupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.Sequence, t.VendorID, t.TypeID, t.MediaID, t.IsThumbNailImage });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sequence)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MediaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Resolution)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("productmedia_backup");
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
        }
    }
}
