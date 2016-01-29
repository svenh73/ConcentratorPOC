using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiCommunicationMap : EntityTypeConfiguration<EdiCommunication>
    {
        public EdiCommunicationMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiCommunicationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Schedule)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Connection)
                .HasMaxLength(150);

            this.Property(t => t.Remark)
                .HasMaxLength(255);

            this.Property(t => t.ResponseType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EdiCommunication");
            this.Property(t => t.EdiCommunicationID).HasColumnName("EdiCommunicationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Schedule).HasColumnName("Schedule");
            this.Property(t => t.LastRun).HasColumnName("LastRun");
            this.Property(t => t.NextRun).HasColumnName("NextRun");
            this.Property(t => t.Query).HasColumnName("Query");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.EdiConnectionType).HasColumnName("EdiConnectionType");
            this.Property(t => t.Connection).HasColumnName("Connection");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.ResponseType).HasColumnName("ResponseType");
        }
    }
}
