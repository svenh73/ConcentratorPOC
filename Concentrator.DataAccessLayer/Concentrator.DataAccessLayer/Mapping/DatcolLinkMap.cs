using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class DatcolLinkMap : EntityTypeConfiguration<DatcolLink>
    {
        public DatcolLinkMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ShopNumber)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DatcolNumber)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SourceMessage)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("DatcolLink");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ShopNumber).HasColumnName("ShopNumber");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.DatcolNumber).HasColumnName("DatcolNumber");
            this.Property(t => t.SourceMessage).HasColumnName("SourceMessage");

            // Relationships
            this.HasRequired(t => t.Order)
                .WithMany(t => t.DatcolLinks)
                .HasForeignKey(d => d.OrderID);

        }
    }
}
