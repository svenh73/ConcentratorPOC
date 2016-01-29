using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ClientMappingTNTMap : EntityTypeConfiguration<ClientMappingTNT>
    {
        public ClientMappingTNTMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCode);

            // Properties
            this.Property(t => t.ClientCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ClientName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ClientMappingTNT");
            this.Property(t => t.ClientCode).HasColumnName("ClientCode");
            this.Property(t => t.ClientName).HasColumnName("ClientName");
        }
    }
}
