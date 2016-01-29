using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductMatchMap : EntityTypeConfiguration<ProductMatch>
    {
        public ProductMatchMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ProductMatch");
            this.Property(t => t.ProductMatchID).HasColumnName("ProductMatchID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.isMatched).HasColumnName("isMatched");
            this.Property(t => t.MatchPercentage).HasColumnName("MatchPercentage");
            this.Property(t => t.CalculatedMatch).HasColumnName("CalculatedMatch");
            this.Property(t => t.MatchStatus).HasColumnName("MatchStatus");
            this.Property(t => t.Primary).HasColumnName("Primary");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithOptional(t => t.ProductMatch);

        }
    }
}
