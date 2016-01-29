using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MediaTypeMap : EntityTypeConfiguration<MediaType>
    {
        public MediaTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.Type)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("MediaType");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
