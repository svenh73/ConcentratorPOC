using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentLedgerMap : EntityTypeConfiguration<ContentLedger>
    {
        public ContentLedgerMap()
        {
            // Primary Key
            this.HasKey(t => t.LedgerID);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(255);

            this.Property(t => t.LedgerObject)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ContentLedger");
            this.Property(t => t.LedgerID).HasColumnName("LedgerID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.LedgerDate).HasColumnName("LedgerDate");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.ConcentratorStatusID).HasColumnName("ConcentratorStatusID");
            this.Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");
            this.Property(t => t.VendorAssortmentID).HasColumnName("VendorAssortmentID");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.LedgerObject).HasColumnName("LedgerObject");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.Margin).HasColumnName("Margin");
            this.Property(t => t.BasePrice).HasColumnName("BasePrice");
            this.Property(t => t.BaseCostPrice).HasColumnName("BaseCostPrice");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ContentLedgers)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.VendorAssortment)
                .WithMany(t => t.ContentLedgers)
                .HasForeignKey(d => d.VendorAssortmentID);

        }
    }
}
