using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingProductMap : EntityTypeConfiguration<MasterGroupMappingProduct>
    {
        public MasterGroupMappingProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MasterGroupMappingID, t.ProductID });

            // Properties
            this.Property(t => t.MasterGroupMappingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingProduct");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.IsApproved).HasColumnName("IsApproved");
            this.Property(t => t.IsCustom).HasColumnName("IsCustom");
            this.Property(t => t.IsProductMapped).HasColumnName("IsProductMapped");
            this.Property(t => t.ConnectorPublicationRuleID).HasColumnName("ConnectorPublicationRuleID");

            // Relationships
            this.HasOptional(t => t.ConnectorPublicationRule)
                .WithMany(t => t.MasterGroupMappingProducts)
                .HasForeignKey(d => d.ConnectorPublicationRuleID);
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingProducts)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.MasterGroupMappingProducts)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
