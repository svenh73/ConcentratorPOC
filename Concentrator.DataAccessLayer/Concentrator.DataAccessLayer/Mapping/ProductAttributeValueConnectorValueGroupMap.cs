using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeValueConnectorValueGroupMap : EntityTypeConfiguration<ProductAttributeValueConnectorValueGroup>
    {
        public ProductAttributeValueConnectorValueGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Value, t.AttributeID, t.AttributeValueGroupID });

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AttributeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AttributeValueGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductAttributeValueConnectorValueGroup");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeValueGroupID).HasColumnName("AttributeValueGroupID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductAttributeValueConnectorValueGroups)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeValueConnectorValueGroups)
                .HasForeignKey(d => d.AttributeID);
            this.HasRequired(t => t.ProductAttributeValueGroup)
                .WithMany(t => t.ProductAttributeValueConnectorValueGroups)
                .HasForeignKey(d => d.AttributeValueGroupID);

        }
    }
}
