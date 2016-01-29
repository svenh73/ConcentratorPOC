using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintLayoutMap : EntityTypeConfiguration<WebToPrintLayout>
    {
        public WebToPrintLayoutMap()
        {
            // Primary Key
            this.HasKey(t => t.LayoutID);

            // Properties
            this.Property(t => t.LayoutType)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("WebToPrintLayout");
            this.Property(t => t.LayoutID).HasColumnName("LayoutID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.LayoutType).HasColumnName("LayoutType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasRequired(t => t.WebToPrintProject)
                .WithMany(t => t.WebToPrintLayouts)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
