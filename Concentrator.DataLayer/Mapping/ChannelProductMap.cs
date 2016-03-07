using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataAccessLayer.Mapping
{
    public class ChannelProductMap : EntityTypeConfiguration<ChannelProduct>
    {
        public ChannelProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ChannelProduct");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ChannelId).HasColumnName("ChannelId");
            this.Property(t => t.StartDateTime).HasColumnName("StartDateTime");
            this.Property(t => t.EndDateTime).HasColumnName("EndDateTime");

            // Relationships
            this.HasRequired(t => t.Channel)
                .WithMany(t => t.ChannelProducts)
                .HasForeignKey(d => d.ChannelId);
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ChannelProducts)
                .HasForeignKey(d => d.ProductId);

        }
    }
}
