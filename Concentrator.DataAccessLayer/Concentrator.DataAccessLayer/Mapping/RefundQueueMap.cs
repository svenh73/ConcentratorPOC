using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RefundQueueMap : EntityTypeConfiguration<RefundQueue>
    {
        public RefundQueueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.OrderResponseID });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderResponseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WebsiteOrderNumber)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RefundQueue");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderResponseID).HasColumnName("OrderResponseID");
            this.Property(t => t.Valid).HasColumnName("Valid");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.WebsiteOrderNumber).HasColumnName("WebsiteOrderNumber");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.RefundQueues)
                .HasForeignKey(d => d.OrderID);
            this.HasRequired(t => t.OrderResponse)
                .WithMany(t => t.RefundQueues)
                .HasForeignKey(d => d.OrderResponseID);

        }
    }
}
