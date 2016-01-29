using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class CommunicatorMessageMap : EntityTypeConfiguration<CommunicatorMessage>
    {
        public CommunicatorMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LocalSubPath)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.RemoteSubPath)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CommunicatorMessage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.LocalSubPath).HasColumnName("LocalSubPath");
            this.Property(t => t.RemoteSubPath).HasColumnName("RemoteSubPath");
            this.Property(t => t.Incoming).HasColumnName("Incoming");

            // Relationships
            this.HasMany(t => t.Vendors)
                .WithMany(t => t.CommunicatorMessages)
                .Map(m =>
                    {
                        m.ToTable("VendorCommunicatorMessage");
                        m.MapLeftKey("MessageID");
                        m.MapRightKey("VendorID");
                    });


        }
    }
}
