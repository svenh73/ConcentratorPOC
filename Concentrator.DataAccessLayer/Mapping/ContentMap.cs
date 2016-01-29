using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentMap : EntityTypeConfiguration<Content>
    {
        public ContentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.ConnectorID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShortDescription)
                .HasMaxLength(255);

            this.Property(t => t.LongDescription)
                .HasMaxLength(255);

            this.Property(t => t.LineType)
                .HasMaxLength(50);

            this.Property(t => t.LedgerClass)
                .HasMaxLength(50);

            this.Property(t => t.ProductDesk)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Content");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            this.Property(t => t.LongDescription).HasColumnName("LongDescription");
            this.Property(t => t.LineType).HasColumnName("LineType");
            this.Property(t => t.LedgerClass).HasColumnName("LedgerClass");
            this.Property(t => t.ProductDesk).HasColumnName("ProductDesk");
            this.Property(t => t.ExtendedCatalog).HasColumnName("ExtendedCatalog");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.ProductContentID).HasColumnName("ProductContentID");
            this.Property(t => t.ConnectorPublicationRuleID).HasColumnName("ConnectorPublicationRuleID");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.Contents)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.ContentProduct)
                .WithMany(t => t.Contents)
                .HasForeignKey(d => d.ProductContentID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.Contents)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.Contents)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.Contents1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);

        }
    }
}
