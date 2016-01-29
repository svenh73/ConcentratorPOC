using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderListenerMap : EntityTypeConfiguration<EdiOrderListener>
    {
        public EdiOrderListenerMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiRequestID);

            // Properties
            this.Property(t => t.CustomerName)
                .HasMaxLength(255);

            this.Property(t => t.CustomerIP)
                .HasMaxLength(50);

            this.Property(t => t.CustomerHostName)
                .HasMaxLength(50);

            this.Property(t => t.ResponseRemark)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EdiOrderListener");
            this.Property(t => t.EdiRequestID).HasColumnName("EdiRequestID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CustomerIP).HasColumnName("CustomerIP");
            this.Property(t => t.CustomerHostName).HasColumnName("CustomerHostName");
            this.Property(t => t.RequestDocument).HasColumnName("RequestDocument");
            this.Property(t => t.ReceivedDate).HasColumnName("ReceivedDate");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.ResponseRemark).HasColumnName("ResponseRemark");
            this.Property(t => t.ResponseTime).HasColumnName("ResponseTime");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.EdiOrderListeners)
                .HasForeignKey(d => d.ConnectorID);

        }
    }
}
