using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ScanDataMap : EntityTypeConfiguration<ScanData>
    {
        public ScanDataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupMappingID, t.ConnectorID });

            // Properties
            this.Property(t => t.ProductGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ScanTime)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ScanDisplay)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ScanData");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.ScanTime).HasColumnName("ScanTime");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.ScanDisplay).HasColumnName("ScanDisplay");

            // Relationships
            this.HasRequired(t => t.ProductGroupMapping)
                .WithMany(t => t.ScanDatas)
                .HasForeignKey(d => d.ProductGroupMappingID);

        }
    }
}
