using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiFieldMappingMap : EntityTypeConfiguration<EdiFieldMapping>
    {
        public EdiFieldMappingMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiMappingID);

            // Properties
            this.Property(t => t.TableName)
                .HasMaxLength(1000);

            this.Property(t => t.FieldName)
                .HasMaxLength(50);

            this.Property(t => t.VendorFieldName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorTableName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VendorFieldLength)
                .HasMaxLength(50);

            this.Property(t => t.VendorDefaultValue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EdiFieldMapping");
            this.Property(t => t.EdiMappingID).HasColumnName("EdiMappingID");
            this.Property(t => t.TableName).HasColumnName("TableName");
            this.Property(t => t.FieldName).HasColumnName("FieldName");
            this.Property(t => t.EdiVendorID).HasColumnName("EdiVendorID");
            this.Property(t => t.VendorFieldName).HasColumnName("VendorFieldName");
            this.Property(t => t.VendorTableName).HasColumnName("VendorTableName");
            this.Property(t => t.VendorFieldLength).HasColumnName("VendorFieldLength");
            this.Property(t => t.VendorDefaultValue).HasColumnName("VendorDefaultValue");
            this.Property(t => t.EdiType).HasColumnName("EdiType");
            this.Property(t => t.EdiCommunicationID).HasColumnName("EdiCommunicationID");
            this.Property(t => t.MatchField).HasColumnName("MatchField");
            this.Property(t => t.VendorFieldType).HasColumnName("VendorFieldType");

            // Relationships
            this.HasOptional(t => t.EdiCommunication)
                .WithMany(t => t.EdiFieldMappings)
                .HasForeignKey(d => d.EdiCommunicationID);
            this.HasRequired(t => t.EdiVendor)
                .WithMany(t => t.EdiFieldMappings)
                .HasForeignKey(d => d.EdiVendorID);

        }
    }
}
