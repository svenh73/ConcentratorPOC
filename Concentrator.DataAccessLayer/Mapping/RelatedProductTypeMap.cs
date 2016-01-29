using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RelatedProductTypeMap : EntityTypeConfiguration<RelatedProductType>
    {
        public RelatedProductTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.RelatedProductTypeID);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RelatedProductType");
            this.Property(t => t.RelatedProductTypeID).HasColumnName("RelatedProductTypeID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.IsConfigured).HasColumnName("IsConfigured");
            this.Property(t => t.TypeMapsToMagentoTypeID).HasColumnName("TypeMapsToMagentoTypeID");
        }
    }
}
