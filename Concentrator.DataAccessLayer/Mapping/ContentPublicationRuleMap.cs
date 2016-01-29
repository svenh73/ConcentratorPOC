using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ContentPublicationRuleMap : EntityTypeConfiguration<ContentPublicationRule>
    {
        public ContentPublicationRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentPublicationRuleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContentPublicationRule");
            this.Property(t => t.ContentPublicationRuleID).HasColumnName("ContentPublicationRuleID");
            this.Property(t => t.ProductContentID).HasColumnName("ProductContentID");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.Publish).HasColumnName("Publish");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.RuleIndex).HasColumnName("RuleIndex");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.UpdateFrequentie).HasColumnName("UpdateFrequentie");
            this.Property(t => t.PublicationType).HasColumnName("PublicationType");

            // Relationships
            this.HasOptional(t => t.AssortmentStatus)
                .WithMany(t => t.ContentPublicationRules)
                .HasForeignKey(d => d.StatusID);
            this.HasRequired(t => t.ContentProduct)
                .WithMany(t => t.ContentPublicationRules)
                .HasForeignKey(d => d.ProductContentID);

        }
    }
}
