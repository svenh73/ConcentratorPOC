using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductGroupMappingCustomLabelMap : EntityTypeConfiguration<ProductGroupMappingCustomLabel>
    {
        public ProductGroupMappingCustomLabelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductGroupMappingID, t.LanguageID });

            // Properties
            this.Property(t => t.ProductGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustomLabel)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ProductGroupMappingCustomLabel");
            this.Property(t => t.ProductGroupMappingID).HasColumnName("ProductGroupMappingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.CustomLabel).HasColumnName("CustomLabel");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ProductGroupMappingCustomLabels)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.ProductGroupMappingCustomLabels)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.ProductGroupMapping)
                .WithMany(t => t.ProductGroupMappingCustomLabels)
                .HasForeignKey(d => d.ProductGroupMappingID);

        }
    }
}
