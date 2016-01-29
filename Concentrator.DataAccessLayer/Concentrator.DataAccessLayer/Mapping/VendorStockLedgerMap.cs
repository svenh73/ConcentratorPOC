using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorStockLedgerMap : EntityTypeConfiguration<VendorStockLedger>
    {
        public VendorStockLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.LedgerID);

            // Properties
            this.Property(t => t.StockStatusOld)
                .HasMaxLength(50);

            this.Property(t => t.StockStatusNew)
                .HasMaxLength(50);

            this.Property(t => t.VendorStatusOld)
                .HasMaxLength(50);

            this.Property(t => t.VendorStatusNew)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorStockLedger");
            this.Property(t => t.LedgerID).HasColumnName("LedgerID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorStockTypeID).HasColumnName("VendorStockTypeID");
            this.Property(t => t.QuantityOnHandOld).HasColumnName("QuantityOnHandOld");
            this.Property(t => t.QuantityOnHandNew).HasColumnName("QuantityOnHandNew");
            this.Property(t => t.PromisedDeliveryDateOld).HasColumnName("PromisedDeliveryDateOld");
            this.Property(t => t.PromisedDeliveryDateNew).HasColumnName("PromisedDeliveryDateNew");
            this.Property(t => t.QuantityToReceiveOld).HasColumnName("QuantityToReceiveOld");
            this.Property(t => t.QuantityToReceiveNew).HasColumnName("QuantityToReceiveNew");
            this.Property(t => t.StockStatusOld).HasColumnName("StockStatusOld");
            this.Property(t => t.StockStatusNew).HasColumnName("StockStatusNew");
            this.Property(t => t.UnitCostOld).HasColumnName("UnitCostOld");
            this.Property(t => t.UnitCostNew).HasColumnName("UnitCostNew");
            this.Property(t => t.ConcentratorStatusIDOld).HasColumnName("ConcentratorStatusIDOld");
            this.Property(t => t.ConcentratorStatusIDNew).HasColumnName("ConcentratorStatusIDNew");
            this.Property(t => t.VendorStatusOld).HasColumnName("VendorStatusOld");
            this.Property(t => t.VendorStatusNew).HasColumnName("VendorStatusNew");
            this.Property(t => t.LedgerDateTime).HasColumnName("LedgerDateTime");
        }
    }
}
