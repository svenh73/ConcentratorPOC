using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintBindingMap : EntityTypeConfiguration<WebToPrintBinding>
    {
        public WebToPrintBindingMap()
        {
            // Primary Key
            this.HasKey(t => t.BindingID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Query)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("WebToPrintBinding");
            this.Property(t => t.BindingID).HasColumnName("BindingID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Query).HasColumnName("Query");
            this.Property(t => t.QueryText).HasColumnName("QueryText");
        }
    }
}
