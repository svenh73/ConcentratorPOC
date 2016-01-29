using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ReviewSourceMap : EntityTypeConfiguration<ReviewSource>
    {
        public ReviewSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.SourceID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CountryCode)
                .HasMaxLength(50);

            this.Property(t => t.LanguageCode)
                .HasMaxLength(50);

            this.Property(t => t.SourceUrl)
                .HasMaxLength(200);

            this.Property(t => t.SourceLogoUrl)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ReviewSource");
            this.Property(t => t.SourceID).HasColumnName("SourceID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.LanguageCode).HasColumnName("LanguageCode");
            this.Property(t => t.SourceUrl).HasColumnName("SourceUrl");
            this.Property(t => t.SourceLogoUrl).HasColumnName("SourceLogoUrl");
            this.Property(t => t.SourceRank).HasColumnName("SourceRank");
            this.Property(t => t.CustomSourceID).HasColumnName("CustomSourceID");
        }
    }
}
