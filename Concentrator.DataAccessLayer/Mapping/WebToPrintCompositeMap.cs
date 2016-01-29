using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintCompositeMap : EntityTypeConfiguration<WebToPrintComposite>
    {
        public WebToPrintCompositeMap()
        {
            // Primary Key
            this.HasKey(t => t.CompositeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("WebToPrintComposite");
            this.Property(t => t.CompositeID).HasColumnName("CompositeID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasRequired(t => t.WebToPrintProject)
                .WithMany(t => t.WebToPrintComposites)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
