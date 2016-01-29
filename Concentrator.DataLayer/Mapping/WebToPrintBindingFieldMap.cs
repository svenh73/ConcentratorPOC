using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WebToPrintBindingFieldMap : EntityTypeConfiguration<WebToPrintBindingField>
    {
        public WebToPrintBindingFieldMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FieldID, t.BindingID });

            // Properties
            this.Property(t => t.FieldID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BindingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("WebToPrintBindingField");
            this.Property(t => t.FieldID).HasColumnName("FieldID");
            this.Property(t => t.BindingID).HasColumnName("BindingID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Options).HasColumnName("Options");

            // Relationships
            this.HasRequired(t => t.WebToPrintBinding)
                .WithMany(t => t.WebToPrintBindingFields)
                .HasForeignKey(d => d.BindingID);

        }
    }
}
