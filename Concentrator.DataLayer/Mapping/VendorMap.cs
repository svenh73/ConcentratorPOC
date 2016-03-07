using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class VendorMap : EntityTypeConfiguration<Vendor>
    {
        public VendorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.VendorId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.VendorType)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Vendor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.VendorId).HasColumnName("VendorId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.VendorType).HasColumnName("VendorType");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Vendors)
                .HasForeignKey(d => d.Id);
            //this.HasRequired(t => t.SettingValue)
            //    .WithMany(t => t.Vendors)
            //    .HasForeignKey(d => d.Id);
            this.HasRequired(t => t.VendorProduct)
                .WithMany(t => t.Vendors)
                .HasForeignKey(d => d.Id);

        }
    }
}
