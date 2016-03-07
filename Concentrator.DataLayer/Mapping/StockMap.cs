using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.ChannelProductId, t.Quantity, t.LastModified });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChannelProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Stock");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VendorProductId).HasColumnName("VendorProductId");
            this.Property(t => t.ChannelProductId).HasColumnName("ChannelProductId");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.LastModified).HasColumnName("LastModified");

            // Relationships
            this.HasRequired(t => t.ChannelProduct)
                .WithMany(t => t.Stocks)
                .HasForeignKey(d => d.ChannelProductId);
            this.HasRequired(t => t.StockType)
                .WithMany(t => t.Stocks)
                .HasForeignKey(d => d.Id);
            this.HasOptional(t => t.VendorProduct)
                .WithMany(t => t.Stocks)
                .HasForeignKey(d => d.VendorProductId);

        }
    }
}
