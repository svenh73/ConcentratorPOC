using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class AttributeValueMap : EntityTypeConfiguration<AttributeValue>
    {
        public AttributeValueMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeId);

            // Properties
            this.Property(t => t.AttributeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Value)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AttributeValue");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Attribute)
                .WithOptional(t => t.AttributeValue);


            this.HasRequired(t => t.Product)
                .WithMany(t => t.AttributeValues)
                .HasForeignKey(d => d.ProductId);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.AttributeValues)
                .HasForeignKey(d => d.LanguageId);

        }
    }
}
