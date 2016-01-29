using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class FaqMap : EntityTypeConfiguration<Faq>
    {
        public FaqMap()
        {
            // Primary Key
            this.HasKey(t => t.FaqID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Faq");
            this.Property(t => t.FaqID).HasColumnName("FaqID");
            this.Property(t => t.Mandatory).HasColumnName("Mandatory");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
        }
    }
}
