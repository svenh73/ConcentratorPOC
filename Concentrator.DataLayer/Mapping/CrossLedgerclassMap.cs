using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class CrossLedgerclassMap : EntityTypeConfiguration<CrossLedgerclass>
    {
        public CrossLedgerclassMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ConnectorID, t.LedgerclassCode });

            // Properties
            this.Property(t => t.ConnectorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LedgerclassCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CrossLedgerclassCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CrossLedgerclass");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.LedgerclassCode).HasColumnName("LedgerclassCode");
            this.Property(t => t.CrossLedgerclassCode).HasColumnName("CrossLedgerclassCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.CrossLedgerclasses)
                .HasForeignKey(d => d.ConnectorID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.CrossLedgerclasses)
                .HasForeignKey(d => d.CreatedBy).WillCascadeOnDelete(false);
            this.HasOptional(t => t.User1)
                .WithMany(t => t.CrossLedgerclasses1)
                .HasForeignKey(d => d.LastModifiedBy).WillCascadeOnDelete(false);

        }
    }
}
