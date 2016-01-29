using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class AttributeMatchStoreMap : EntityTypeConfiguration<AttributeMatchStore>
    {
        public AttributeMatchStoreMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AttributeStoreID, t.AttributeID, t.ConnectorID });

            // Properties
            this.Property(t => t.AttributeStoreID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AttributeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StoreName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("AttributeMatchStore");
            this.Property(t => t.AttributeStoreID).HasColumnName("AttributeStoreID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.StoreName).HasColumnName("StoreName");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.AttributeMatchStores)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.AttributeMatchStores)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
