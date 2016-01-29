using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OrderItemFullfilmentInformationMap : EntityTypeConfiguration<OrderItemFullfilmentInformation>
    {
        public OrderItemFullfilmentInformationMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderFullfilmentInformationID);

            // Properties
            this.Property(t => t.Sequence)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(255);

            this.Property(t => t.Unit)
                .HasMaxLength(255);

            this.Property(t => t.SupportType)
                .HasMaxLength(255);

            this.Property(t => t.SupportID)
                .HasMaxLength(255);

            this.Property(t => t.Label)
                .HasMaxLength(255);

            this.Property(t => t.Code)
                .HasMaxLength(255);

            this.Property(t => t.Value)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("OrderItemFullfilmentInformation");
            this.Property(t => t.OrderResponseLineID).HasColumnName("OrderResponseLineID");
            this.Property(t => t.Sequence).HasColumnName("Sequence");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Header).HasColumnName("Header");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.SupportType).HasColumnName("SupportType");
            this.Property(t => t.SupportID).HasColumnName("SupportID");
            this.Property(t => t.Label).HasColumnName("Label");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.OrderFullfilmentInformationID).HasColumnName("OrderFullfilmentInformationID");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.OrderResponseLine)
                .WithMany(t => t.OrderItemFullfilmentInformations)
                .HasForeignKey(d => d.OrderResponseLineID);

        }
    }
}
