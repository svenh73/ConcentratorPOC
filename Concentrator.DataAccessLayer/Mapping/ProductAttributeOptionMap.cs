using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeOptionMap : EntityTypeConfiguration<ProductAttributeOption>
    {
        public ProductAttributeOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.OptionID);

            // Properties
            this.Property(t => t.AttributeOption)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ProductAttributeOption");
            this.Property(t => t.OptionID).HasColumnName("OptionID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeOption).HasColumnName("AttributeOption");

            // Relationships
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ProductAttributeOptions)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
