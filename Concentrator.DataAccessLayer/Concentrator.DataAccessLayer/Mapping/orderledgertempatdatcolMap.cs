using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class orderledgertempatdatcolMap : EntityTypeConfiguration<orderledgertempatdatcol>
    {
        public orderledgertempatdatcolMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderLedgerID, t.OrderLineID, t.Status, t.LedgerDate });

            // Properties
            this.Property(t => t.OrderLedgerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OrderLineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("orderledgertempatdatcol");
            this.Property(t => t.OrderLedgerID).HasColumnName("OrderLedgerID");
            this.Property(t => t.OrderLineID).HasColumnName("OrderLineID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LedgerDate).HasColumnName("LedgerDate");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
        }
    }
}
