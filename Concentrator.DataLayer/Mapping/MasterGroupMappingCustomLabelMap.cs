using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MasterGroupMappingCustomLabelMap : EntityTypeConfiguration<MasterGroupMappingCustomLabel>
    {
        public MasterGroupMappingCustomLabelMap()
        {
            // Primary Key
            this.HasKey(t => t.MasterGroupMappingCustomLabelID);

            // Properties
            this.Property(t => t.CustomLabel)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MasterGroupMappingCustomLabel");
            this.Property(t => t.MasterGroupMappingCustomLabelID).HasColumnName("MasterGroupMappingCustomLabelID");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.CustomLabel).HasColumnName("CustomLabel");

            // Relationships
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.MasterGroupMappingCustomLabels)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.Language)
                .WithMany(t => t.MasterGroupMappingCustomLabels)
                .HasForeignKey(d => d.LanguageID);
            this.HasRequired(t => t.MasterGroupMapping)
                .WithMany(t => t.MasterGroupMappingCustomLabels)
                .HasForeignKey(d => d.MasterGroupMappingID);

        }
    }
}
