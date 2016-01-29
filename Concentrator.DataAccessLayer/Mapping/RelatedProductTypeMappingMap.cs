using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RelatedProductTypeMappingMap : EntityTypeConfiguration<RelatedProductTypeMapping>
    {
        public RelatedProductTypeMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.RelatedProductTypeMappingID);

            // Properties
            this.Property(t => t.RelatedProductTypeMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RelatedProductTypeMappingName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RelatedProductTypeMapping");
            this.Property(t => t.RelatedProductTypeMappingID).HasColumnName("RelatedProductTypeMappingID");
            this.Property(t => t.RelatedProductTypeMappingName).HasColumnName("RelatedProductTypeMappingName");
        }
    }
}
