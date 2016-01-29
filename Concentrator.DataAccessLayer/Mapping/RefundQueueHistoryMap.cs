using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RefundQueueHistoryMap : EntityTypeConfiguration<RefundQueueHistory>
    {
        public RefundQueueHistoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.OrderResponseID });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderResponseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RefundQueueHistory");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderResponseID).HasColumnName("OrderResponseID");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.ProcessedTime).HasColumnName("ProcessedTime");
        }
    }
}
