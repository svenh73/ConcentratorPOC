using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderLedgerStatuMap : EntityTypeConfiguration<OrderLedgerStatu>
    {
        public OrderLedgerStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.Status);

            // Properties
            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderLedgerStatus");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
