using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintDocumentMap : EntityTypeConfiguration<WebToPrintDocument>
    {
        public WebToPrintDocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("WebToPrintDocument");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasRequired(t => t.WebToPrintProject)
                .WithMany(t => t.WebToPrintDocuments)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
