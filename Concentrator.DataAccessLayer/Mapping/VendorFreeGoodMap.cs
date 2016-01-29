using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorFreeGoodMap : EntityTypeConfiguration<VendorFreeGood>
    {
        public VendorFreeGoodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorAssortmentID, t.ProductID });

            // Properties
            this.Property(t => t.VendorAssortmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("VendorFreeGoods");
            this.Property(t => t.VendorAssortmentID).HasColumnName("VendorAssortmentID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.OverOrderedQuantity).HasColumnName("OverOrderedQuantity");
            this.Property(t => t.FreeGoodQuantity).HasColumnName("FreeGoodQuantity");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.VendorFreeGoods)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.VendorAssortment)
                .WithMany(t => t.VendorFreeGoods)
                .HasForeignKey(d => d.VendorAssortmentID);

        }
    }
}
