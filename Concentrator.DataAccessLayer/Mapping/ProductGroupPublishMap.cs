using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupPublishMap : EntityTypeConfiguration<ProductGroupPublish>
    {
        public ProductGroupPublishMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupID, t.ConnectorID });

            // Properties
            this.Property(t => t.ProductGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductGroupPublish");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.Published).HasColumnName("Published");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ProductGroupPublishes)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ProductGroup)
                .WithMany(t => t.ProductGroupPublishes)
                .HasForeignKey(d => d.ProductGroupID);

        }
    }
}
