using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ProductReviewMap : EntityTypeConfiguration<ProductReview>
    {
        public ProductReviewMap()
        {
            // Primary Key
            this.HasKey(t => t.ReviewID);

            // Properties
            this.Property(t => t.ReviewURL)
                .HasMaxLength(200);

            this.Property(t => t.CustomID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProductReview");
            this.Property(t => t.ReviewID).HasColumnName("ReviewID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.SourceID).HasColumnName("SourceID");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.IsSummary).HasColumnName("IsSummary");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Verdict).HasColumnName("Verdict");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.ReviewURL).HasColumnName("ReviewURL");
            this.Property(t => t.SourceRating).HasColumnName("SourceRating");
            this.Property(t => t.CustomID).HasColumnName("CustomID");
            this.Property(t => t.RatingImageURL).HasColumnName("RatingImageURL");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.ProductID);
            this.HasRequired(t => t.ReviewSource)
                .WithMany(t => t.ProductReviews)
                .HasForeignKey(d => d.SourceID);

        }
    }
}
