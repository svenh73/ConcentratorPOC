using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PushProductMap : EntityTypeConfiguration<PushProduct>
    {
        public PushProductMap()
        {
            // Primary Key
            this.HasKey(t => t.PushProductID);

            // Properties
            this.Property(t => t.CustomItemNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PushProduct");
            this.Property(t => t.PushProductID).HasColumnName("PushProductID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CustomItemNumber).HasColumnName("CustomItemNumber");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.LastPushDate).HasColumnName("LastPushDate");
        }
    }
}
