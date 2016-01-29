using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentPriceCalculationMap : EntityTypeConfiguration<ContentPriceCalculation>
    {
        public ContentPriceCalculationMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentPriceCalculationID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Calculation)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ContentPriceCalculation");
            this.Property(t => t.ContentPriceCalculationID).HasColumnName("ContentPriceCalculationID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.Calculation).HasColumnName("Calculation");
        }
    }
}
