using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderLedgerMap : EntityTypeConfiguration<OrderLedger>
    {
        public OrderLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderLedgerID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OrderLedger");
            this.Property(t => t.OrderLedgerID).HasColumnName("OrderLedgerID");
            this.Property(t => t.OrderLineID).HasColumnName("OrderLineID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LedgerDate).HasColumnName("LedgerDate");
            this.Property(t => t.Quantity).HasColumnName("Quantity");

            // Relationships
            this.HasRequired(t => t.OrderLine)
                .WithMany(t => t.OrderLedgers)
                .HasForeignKey(d => d.OrderLineID);

        }
    }
}
