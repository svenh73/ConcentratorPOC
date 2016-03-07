using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class AttributeOptionMap : EntityTypeConfiguration<AttributeOption>
    {
        public AttributeOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AttributeOption");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Default).HasColumnName("Default");
            this.Property(t => t.Index).HasColumnName("Index");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Attribute)
                .WithMany(t => t.AttributeOptions)
                .HasForeignKey(d => d.AttributeId);

        }
    }
}
