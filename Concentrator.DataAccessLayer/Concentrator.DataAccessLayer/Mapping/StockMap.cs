using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Stock");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.QuantityOnHand).HasColumnName("QuantityOnHand");
            this.Property(t => t.PromisedDeliveryDate).HasColumnName("PromisedDeliveryDate");
            this.Property(t => t.QuantityToReceive).HasColumnName("QuantityToReceive");
        }
    }
}
