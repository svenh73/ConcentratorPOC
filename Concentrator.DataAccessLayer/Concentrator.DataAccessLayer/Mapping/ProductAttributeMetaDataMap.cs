using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductAttributeMetaDataMap : EntityTypeConfiguration<ProductAttributeMetaData>
    {
        public ProductAttributeMetaDataMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeID);

            // Properties
            this.Property(t => t.AttributeCode)
                .HasMaxLength(150);

            this.Property(t => t.FormatString)
                .HasMaxLength(50);

            this.Property(t => t.DataType)
                .HasMaxLength(50);

            this.Property(t => t.Sign)
                .HasMaxLength(50);

            this.Property(t => t.AttributePath)
                .HasMaxLength(255);

            this.Property(t => t.DefaultValue)
                .HasMaxLength(50);

            this.Property(t => t.FrontendType)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("ProductAttributeMetaData");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeCode).HasColumnName("AttributeCode");
            this.Property(t => t.ProductAttributeGroupID).HasColumnName("ProductAttributeGroupID");
            this.Property(t => t.FormatString).HasColumnName("FormatString");
            this.Property(t => t.DataType).HasColumnName("DataType");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.NeedsUpdate).HasColumnName("NeedsUpdate");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.IsSearchable).HasColumnName("IsSearchable");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.AttributePath).HasColumnName("AttributePath");
            this.Property(t => t.Mandatory).HasColumnName("Mandatory");
            this.Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            this.Property(t => t.IsConfigurable).HasColumnName("IsConfigurable");
            this.Property(t => t.ConfigurablePosition).HasColumnName("ConfigurablePosition");
            this.Property(t => t.HasOption).HasColumnName("HasOption");
            this.Property(t => t.IsSlider).HasColumnName("IsSlider");
            this.Property(t => t.FrontendType).HasColumnName("FrontendType");

            // Relationships
            this.HasRequired(t => t.ProductAttributeGroupMetaData)
                .WithMany(t => t.ProductAttributeMetaDatas)
                .HasForeignKey(d => d.ProductAttributeGroupID);
            this.HasOptional(t => t.Vendor)
                .WithMany(t => t.ProductAttributeMetaDatas)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
