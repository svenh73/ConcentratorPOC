using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingMediaMap : EntityTypeConfiguration<MasterGroupMappingMedia>
    {
        public MasterGroupMappingMediaMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingMediaID);

            // Properties
            this.Property(t => t.ImagePath)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingMedia");
            this.Property(t => t.MasterGroupMappingMediaID).HasColumnName("MasterGroupMappingMediaID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.ImageTypeID).HasColumnName("ImageTypeID");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.MasterGroupMappingMedias)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.Language)
                .WithMany(t => t.MasterGroupMappingMedias)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingMedias)
                .HasForeignKey(d => d.MasterGroupMappingID);

        }
    }
}
