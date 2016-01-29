using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => t.VendorID);

            // Properties
            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BackendVendorCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vendor");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.VendorType).HasColumnName("VendorType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.BackendVendorCode).HasColumnName("BackendVendorCode");
            this.Property(t => t.ParentVendorID).HasColumnName("ParentVendorID");
            this.Property(t => t.OrderDispatcherType).HasColumnName("OrderDispatcherType");
            this.Property(t => t.CDPrice).HasColumnName("CDPrice");
            this.Property(t => t.DSPrice).HasColumnName("DSPrice");
            this.Property(t => t.PurchaseOrderType).HasColumnName("PurchaseOrderType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.CutOffTime).HasColumnName("CutOffTime");
            this.Property(t => t.DeliveryHours).HasColumnName("DeliveryHours");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");

            // Relationships
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Vendors)
                .HasForeignKey(d => d.OrganizationID);

        }
    }
}
