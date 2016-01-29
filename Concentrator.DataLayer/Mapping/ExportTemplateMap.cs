using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ExportTemplateMap : EntityTypeConfiguration<ExportTemplate>
    {
        public ExportTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ExportTemplateID);

            // Properties
            this.Property(t => t.ExportTemplateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TemplateName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ExportTemplate");
            this.Property(t => t.ExportTemplateID).HasColumnName("ExportTemplateID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.ManagementPageID).HasColumnName("ManagementPageID");
            this.Property(t => t.TemplateName).HasColumnName("TemplateName");

            // Relationships
            this.HasRequired(t => t.ManagementPage)
                .WithMany(t => t.ExportTemplates)
                .HasForeignKey(d => d.ManagementPageID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.ExportTemplates)
                .HasForeignKey(d => d.UserID);

        }
    }
}
