using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class WehkampMessageMap : EntityTypeConfiguration<WehkampMessage>
    {
        public WehkampMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.MessageID);

            // Properties
            this.Property(t => t.Filename)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Path)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("WehkampMessage");
            this.Property(t => t.MessageID).HasColumnName("MessageID");
            this.Property(t => t.MessageType).HasColumnName("MessageType");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Received).HasColumnName("Received");
            this.Property(t => t.Sent).HasColumnName("Sent");
            this.Property(t => t.LastModified).HasColumnName("LastModified");
            this.Property(t => t.Attempts).HasColumnName("Attempts");
            this.Property(t => t.VendorID).HasColumnName("VendorID");

            // Relationships
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.WehkampMessages)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
