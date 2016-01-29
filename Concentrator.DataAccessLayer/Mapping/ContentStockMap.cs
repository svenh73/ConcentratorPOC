using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentStockMap : EntityTypeConfiguration<ContentStock>
    {
        public ContentStockMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorID, t.ConnectorID, t.VendorStockTypeID });

            // Properties
            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorStockTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ContentStock");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.VendorStockTypeID).HasColumnName("VendorStockTypeID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ContentStocks)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ContentStocks)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.ContentStocks1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ContentStocks)
                .HasForeignKey(d => d.VendorID);
            this.HasRequired(t => t.VendorStockType)
                .WithMany(t => t.ContentStocks)
                .HasForeignKey(d => d.VendorStockTypeID);

        }
    }
}
