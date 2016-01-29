using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class RelatedProductTypeMappingDataMap : EntityTypeConfiguration<RelatedProductTypeMappingData>
    {
        public RelatedProductTypeMappingDataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RelatedProductTypeMappingID, t.RelatedProductTypeID, t.ConnectorID });

            // Properties
            this.Property(t => t.RelatedProductTypeMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RelatedProductTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RelatedProductTypeMappingData");
            this.Property(t => t.RelatedProductTypeMappingID).HasColumnName("RelatedProductTypeMappingID");
            this.Property(t => t.RelatedProductTypeID).HasColumnName("RelatedProductTypeID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
        }
    }
}
