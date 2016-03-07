using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class ChannelMap : EntityTypeConfiguration<Channel>
    {
        public ChannelMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Channel");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ParentChannelId).HasColumnName("ParentChannelId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");

            // Relationships
            this.HasRequired(t => t.Channel2)
                .WithMany(t => t.Channel1)
                .HasForeignKey(d => d.ParentChannelId);

        }
    }
}
