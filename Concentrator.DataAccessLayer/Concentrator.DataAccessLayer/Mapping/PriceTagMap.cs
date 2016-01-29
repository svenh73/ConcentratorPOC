using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class PriceTagMap : EntityTypeConfiguration<PriceTag>
    {
        public PriceTagMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceTagID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PageSize)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Icon)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PriceTag");
            this.Property(t => t.PriceTagID).HasColumnName("PriceTagID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsLandscape).HasColumnName("IsLandscape");
            this.Property(t => t.PageSize).HasColumnName("PageSize");
            this.Property(t => t.HasFreeTextLine).HasColumnName("HasFreeTextLine");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.MaximumQuantity).HasColumnName("MaximumQuantity");
            this.Property(t => t.Icon).HasColumnName("Icon");
        }
    }
}
