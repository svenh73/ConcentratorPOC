using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeValueMap : EntityTypeConfiguration<ProductAttributeValue>
    {
        public ProductAttributeValueMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeValueID);

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("ProductAttributeValue");
            this.Property(t => t.AttributeValueID).HasColumnName("AttributeValueID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasOptional(t => t.Language)
                .WithMany(t => t.ProductAttributeValues)
                .HasForeignKey(d => d.LanguageID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ProductAttributeValues)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeValues)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
