using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ExcludeProductMap : EntityTypeConfiguration<ExcludeProduct>
    {
        public ExcludeProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ExcludeProductID);

            // Properties
            this.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ExcludeProduct");
            this.Property(t => t.ExcludeProductID).HasColumnName("ExcludeProductID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.Connector)
                .WithMany(t => t.ExcludeProducts)
                .HasForeignKey(d => d.ConnectorID);

        }
    }
}
