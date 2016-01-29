using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class OutboundMap : EntityTypeConfiguration<Outbound>
    {
        public OutboundMap()
        {
            // Primary Key
            this.HasKey(t => t.OutboundID);

            // Properties
            this.Property(t => t.OutboundMessage)
                .IsRequired();

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OutboundUrl)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ResponseRemark)
                .HasMaxLength(255);

            this.Property(t => t.ErrorMessage)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Outbound");
            this.Property(t => t.OutboundID).HasColumnName("OutboundID");
            this.Property(t => t.OutboundMessage).HasColumnName("OutboundMessage");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.OutboundUrl).HasColumnName("OutboundUrl");
            this.Property(t => t.ResponseRemark).HasColumnName("ResponseRemark");
            this.Property(t => t.ResponseTime).HasColumnName("ResponseTime");
            this.Property(t => t.ProcessedCount).HasColumnName("ProcessedCount");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.ProcessDate).HasColumnName("ProcessDate");
            this.Property(t => t.OrderID).HasColumnName("OrderID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.Outbounds)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Order)
                .WithMany(t => t.Outbounds)
                .HasForeignKey(d => d.OrderID);

        }
    }
}
