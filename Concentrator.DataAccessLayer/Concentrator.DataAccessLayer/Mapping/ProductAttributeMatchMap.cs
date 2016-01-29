using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeMatchMap : EntityTypeConfiguration<ProductAttributeMatch>
    {
        public ProductAttributeMatchMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductAttributeMatchID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ProductAttributeMatch");
            this.Property(t => t.ProductAttributeMatchID).HasColumnName("ProductAttributeMatchID");
            this.Property(t => t.ProductAttributeGroupID).HasColumnName("ProductAttributeGroupID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.CorrespondingProductAttributeGroupID).HasColumnName("CorrespondingProductAttributeGroupID");
            this.Property(t => t.CorrespondingAttributeID).HasColumnName("CorrespondingAttributeID");
            this.Property(t => t.IsMatched).HasColumnName("IsMatched");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
        }
    }
}
