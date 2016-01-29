using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class EdiOrderTypeMap : EntityTypeConfiguration<EdiOrderType>
    {
        public EdiOrderTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.EdiOrderTypeID);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EdiOrderType");
            this.Property(t => t.EdiOrderTypeID).HasColumnName("EdiOrderTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
        }
    }
}
