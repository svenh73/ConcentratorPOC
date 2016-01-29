using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintPageMap : EntityTypeConfiguration<WebToPrintPage>
    {
        public WebToPrintPageMap()
        {
            // Primary Key
            this.HasKey(t => t.PageID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Data)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("WebToPrintPage");
            this.Property(t => t.PageID).HasColumnName("PageID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Data).HasColumnName("Data");

            // Relationships
            this.HasRequired(t => t.WebToPrintProject)
                .WithMany(t => t.WebToPrintPages)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
