using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderLedgerMap : EntityTypeConfiguration<EdiOrderLedger>
    {
        public EdiOrderLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderLedgerID);

            // Properties
            // Table & Column Mappings
            this.ToTable("EdiOrderLedger");
            this.Property(t => t.EdiOrderLedgerID).HasColumnName("EdiOrderLedgerID");
            this.Property(t => t.EdiOrderLineID).HasColumnName("EdiOrderLineID");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.LedgerDate).HasColumnName("LedgerDate");

            // Relationships
            this.HasRequired(t => t.EdiOrderLine)
                .WithMany(t => t.EdiOrderLedgers)
                .HasForeignKey(d => d.EdiOrderLineID);

        }
    }
}
