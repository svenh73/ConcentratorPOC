using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorRuleValueMap : EntityTypeConfiguration<ConnectorRuleValue>
    {
        public ConnectorRuleValueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConnectorID, t.RuleID, t.VendorID });

            // Properties
            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VendorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ConnectorRuleValue");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.RuleID).HasColumnName("RuleID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ConnectorRuleValues)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.OrderRule)
                .WithMany(t => t.ConnectorRuleValues)
                .HasForeignKey(d => d.RuleID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ConnectorRuleValues)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
