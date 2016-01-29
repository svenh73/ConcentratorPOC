using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiVendorMap : EntityTypeConfiguration<EdiVendor>
    {
        public EdiVendorMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiVendorID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.EdiVendorType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.CompanyCode)
                .HasMaxLength(50);

            this.Property(t => t.DefaultDocumentType)
                .HasMaxLength(50);

            this.Property(t => t.OrderBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EdiVendor");
            this.Property(t => t.EdiVendorID).HasColumnName("EdiVendorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EdiVendorType).HasColumnName("EdiVendorType");
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
            this.Property(t => t.DefaultDocumentType).HasColumnName("DefaultDocumentType");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
        }
    }
}
