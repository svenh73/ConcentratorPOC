using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class AttributeMap : EntityTypeConfiguration<Attribute>
    {
        public AttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Attribute");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AttributeTypeId).HasColumnName("AttributeTypeId");
            this.Property(t => t.LanguageId).HasColumnName("LanguageId");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasMany(t => t.ProductGroups)
                .WithMany(t => t.Attributes)
                .Map(m =>
                    {
                        m.ToTable("ProductGroupAttributes");
                        m.MapLeftKey("AttributeId");
                        m.MapRightKey("ProductGroupId");
                    });

            this.HasRequired(t => t.Language)
                .WithMany(t => t.Attributes)
                .HasForeignKey(d => d.LanguageId);
            this.HasOptional(t => t.AttributeType)
                .WithMany(t => t.Attributes)
                .HasForeignKey(d => d.AttributeTypeId);

        }
    }
}
