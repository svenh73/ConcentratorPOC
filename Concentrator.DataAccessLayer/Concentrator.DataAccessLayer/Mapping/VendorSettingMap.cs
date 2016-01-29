using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class VendorSettingMap : EntityTypeConfiguration<VendorSetting>
    {
        public VendorSettingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VendorID, t.SettingKey });

            // Properties
            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SettingKey)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VendorSetting");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.SettingKey).HasColumnName("SettingKey");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorSettings)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
