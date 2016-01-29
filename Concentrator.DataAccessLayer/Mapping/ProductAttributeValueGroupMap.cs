using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeValueGroupMap : EntityTypeConfiguration<ProductAttributeValueGroup>
    {
        public ProductAttributeValueGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeValueGroupID);

            // Properties
            this.Property(t => t.ImagePath)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("ProductAttributeValueGroup");
            this.Property(t => t.AttributeValueGroupID).HasColumnName("AttributeValueGroupID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductAttributeValueGroups)
                .HasForeignKey(d => d.ConnectorID);

        }
    }
}
