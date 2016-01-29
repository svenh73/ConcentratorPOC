using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiValidateMap : EntityTypeConfiguration<EdiValidate>
    {
        public EdiValidateMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiValidateID);

            // Properties
            this.Property(t => t.TableName)
                .HasMaxLength(50);

            this.Property(t => t.FieldName)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(50);

            this.Property(t => t.Value)
                .HasMaxLength(50);

            this.Property(t => t.Connection)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("EdiValidate");
            this.Property(t => t.EdiValidateID).HasColumnName("EdiValidateID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.EdiVendorID).HasColumnName("EdiVendorID");
            this.Property(t => t.MaxLength).HasColumnName("MaxLength");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.EdiType).HasColumnName("EdiType");
            this.Property(t => t.EdiValidationType).HasColumnName("EdiValidationType");
            this.Property(t => t.EdiConnectionType).HasColumnName("EdiConnectionType");
            this.Property(t => t.Connection).HasColumnName("Connection");

            // Relationships
            this.HasRequired(t => t.EdiVendor)
                .WithMany(t => t.EdiValidates)
                .HasForeignKey(d => d.EdiVendorID);

        }
    }
}
