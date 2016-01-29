using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorStockMap : EntityTypeConfiguration<VendorStock>
    {
        public VendorStockMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.VendorID, t.VendorStockTypeID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorStockTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockStatus)
                .HasMaxLength(50);

            this.Property(t => t.VendorStatus)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorStock");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.QuantityOnHand).HasColumnName("QuantityOnHand");
            this.Property(t => t.PromisedDeliveryDate).HasColumnName("PromisedDeliveryDate");
            this.Property(t => t.QuantityToReceive).HasColumnName("QuantityToReceive");
            this.Property(t => t.VendorStockTypeID).HasColumnName("VendorStockTypeID");
            this.Property(t => t.StockStatus).HasColumnName("StockStatus");
            this.Property(t => t.UnitCost).HasColumnName("UnitCost");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.VendorStatus).HasColumnName("VendorStatus");

            // Relationships
            this.HasOptional(t => t.AssortmentStatus)
                .WithMany(t => t.VendorStocks)
                .HasForeignKey(d => d.ConcentratorStatusID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.VendorStocks)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorStocks)
                .HasForeignKey(d => d.VendorID);
            this.HasRequired(t => t.VendorStockType)
                .WithMany(t => t.VendorStocks)
                .HasForeignKey(d => d.VendorStockTypeID);

        }
    }
}
