using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingRelatedAttributeMap : EntityTypeConfiguration<MasterGroupMappingRelatedAttribute>
    {
        public MasterGroupMappingRelatedAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.RelatedAttributeID);

            // Properties
            this.Property(t => t.AttributeValue)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingRelatedAttribute");
            this.Property(t => t.RelatedAttributeID).HasColumnName("RelatedAttributeID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");

            // Relationships
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingRelatedAttributes)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasOptional(t => t.MasterGroupMappingRelatedAttribute2)
                .WithMany(t => t.MasterGroupMappingRelatedAttribute1)
                .HasForeignKey(d => d.ParentID);
            this.HasRequired(t => t.ProductAttributeMetaData)
                .WithMany(t => t.MasterGroupMappingRelatedAttributes)
                .HasForeignKey(d => d.AttributeID);

        }
    }
}
