using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorProductMatchMap : EntityTypeConfiguration<VendorProductMatch>
    {
        public VendorProductMatchMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorProductMatchID);

            // Properties
            this.Property(t => t.VendorItemNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorProductMatch");
            this.Property(t => t.VendorProductMatchID).HasColumnName("VendorProductMatchID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.VendorProductID).HasColumnName("VendorProductID");
            this.Property(t => t.VendorItemNumber).HasColumnName("VendorItemNumber");
            this.Property(t => t.MatchPercentage).HasColumnName("MatchPercentage");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.VendorProductMatches)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.Product1)
                .WithMany(t => t.VendorProductMatches1)
                .HasForeignKey(d => d.VendorProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorProductMatches)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
