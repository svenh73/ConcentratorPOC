using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderPostMap : EntityTypeConfiguration<EdiOrderPost>
    {
        public EdiOrderPostMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderPostID);

            // Properties
            this.Property(t => t.EdiBackendOrderID)
                .HasMaxLength(255);

            this.Property(t => t.CustomerOrderID)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PostUrl)
                .HasMaxLength(255);

            this.Property(t => t.ResponseRemark)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EdiOrderPost");
            this.Property(t => t.EdiOrderPostID).HasColumnName("EdiOrderPostID");
            this.Property(t => t.EdiOrderID).HasColumnName("EdiOrderID");
            this.Property(t => t.ConnectorRelationID).HasColumnName("ConnectorRelationID");
            this.Property(t => t.EdiBackendOrderID).HasColumnName("EdiBackendOrderID");
            this.Property(t => t.CustomerOrderID).HasColumnName("CustomerOrderID");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.PostDocument).HasColumnName("PostDocument");
            this.Property(t => t.PostDocumentUrl).HasColumnName("PostDocumentUrl");
            this.Property(t => t.PostUrl).HasColumnName("PostUrl");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ResponseRemark).HasColumnName("ResponseRemark");
            this.Property(t => t.ResponseTime).HasColumnName("ResponseTime");
            this.Property(t => t.ProcessedCount).HasColumnName("ProcessedCount");
            this.Property(t => t.EdiRequestID).HasColumnName("EdiRequestID");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.BSKIdentifier).HasColumnName("BSKIdentifier");
            this.Property(t => t.DocumentCounter).HasColumnName("DocumentCounter");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.EdiOrderPosts)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ConnectorRelation)
                .WithMany(t => t.EdiOrderPosts)
                .HasForeignKey(d => d.ConnectorRelationID);
            this.HasOptional(t => t.EdiOrder)
                .WithMany(t => t.EdiOrderPosts)
                .HasForeignKey(d => d.EdiOrderID);
            this.HasOptional(t => t.EdiOrderListener)
                .WithMany(t => t.EdiOrderPosts)
                .HasForeignKey(d => d.EdiRequestID);

        }
    }
}
