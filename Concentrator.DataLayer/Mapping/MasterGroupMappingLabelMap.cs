using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingLabelMap : EntityTypeConfiguration<MasterGroupMappingLabel>
    {
        public MasterGroupMappingLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingLabelID);

            // Properties
            this.Property(t => t.Label)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingLabel");
            this.Property(t => t.MasterGroupMappingLabelID).HasColumnName("MasterGroupMappingLabelID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.Label).HasColumnName("Label");
            this.Property(t => t.SearchEngine).HasColumnName("SearchEngine");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");

            // Relationships
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingLabels)
                .HasForeignKey(d => d.MasterGroupMappingID);

        }
    }
}
