using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeValueLabelMap : EntityTypeConfiguration<ProductAttributeValueLabel>
    {
        public ProductAttributeValueLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Label)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ProductAttributeValueLabel");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.Label).HasColumnName("Label");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductAttributeValueLabels)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductAttributeValueLabels)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.ProductAttributeValueLabels)
                .HasForeignKey(d => d.OrganizationID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeValueLabels)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
