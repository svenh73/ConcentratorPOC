using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentProductMatchMap : EntityTypeConfiguration<ContentProductMatch>
    {
        public ContentProductMatchMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.Index });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Index)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ContentProductMatch");
            this.Property(t => t.StoreID).HasColumnName("StoreID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsLeading).HasColumnName("IsLeading");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ContentProductMatches)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
