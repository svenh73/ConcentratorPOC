using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorStockTypeMap : EntityTypeConfiguration<VendorStockType>
    {
        public VendorStockTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorStockTypeID);

            // Properties
            this.Property(t => t.StockType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorStockTypes");
            this.Property(t => t.VendorStockTypeID).HasColumnName("VendorStockTypeID");
            this.Property(t => t.StockType).HasColumnName("StockType");
        }
    }
}
