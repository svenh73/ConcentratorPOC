using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ExportTemplateColumnMap : EntityTypeConfiguration<ExportTemplateColumn>
    {
        public ExportTemplateColumnMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportTemplateColumnID);

            // Properties
            this.Property(t => t.ExportTemplateColumnID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.SortOrder)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.FilterOperator)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.FilterType)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ExportTemplateColumn");
            this.Property(t => t.ExportTemplateColumnID).HasColumnName("ExportTemplateColumnID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
            this.Property(t => t.FilterOperator).HasColumnName("FilterOperator");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.FilterType).HasColumnName("FilterType");
            this.Property(t => t.ExportTemplateID).HasColumnName("ExportTemplateID");

            // Relationships
            this.HasRequired(t => t.ExportTemplate)
                .WithMany(t => t.ExportTemplateColumns)
                .HasForeignKey(d => d.ExportTemplateID);

        }
    }
}
