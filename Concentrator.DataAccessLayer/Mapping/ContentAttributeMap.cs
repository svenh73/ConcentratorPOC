using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentAttributeMap : EntityTypeConfiguration<ContentAttribute>
    {
        public ContentAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentAttributeID);

            // Properties
            this.Property(t => t.Sign)
                .HasMaxLength(50);

            this.Property(t => t.AttributeCode)
                .HasMaxLength(50);

            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.AttributeValue)
                .IsRequired()
                .HasMaxLength(3000);

            this.Property(t => t.AttributeName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.AttributePath)
                .HasMaxLength(255);

            this.Property(t => t.AttributeOriginalValue)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("ContentAttribute");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.IsSearchable).HasColumnName("IsSearchable");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.NeedsUpdate).HasColumnName("NeedsUpdate");
            this.Property(t => t.AttributeCode).HasColumnName("AttributeCode");
            this.Property(t => t.GroupIndex).HasColumnName("GroupIndex");
            this.Property(t => t.OrderIndex).HasColumnName("OrderIndex");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.AttributeName).HasColumnName("AttributeName");
            this.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ContentAttributeID).HasColumnName("ContentAttributeID");
            this.Property(t => t.AttributePath).HasColumnName("AttributePath");
            this.Property(t => t.AttributeValueID).HasColumnName("AttributeValueID");
            this.Property(t => t.IsConfigurable).HasColumnName("IsConfigurable");
            this.Property(t => t.AttributeOriginalValue).HasColumnName("AttributeOriginalValue");
            this.Property(t => t.ConfigurablePosition).HasColumnName("ConfigurablePosition");
        }
    }
}
