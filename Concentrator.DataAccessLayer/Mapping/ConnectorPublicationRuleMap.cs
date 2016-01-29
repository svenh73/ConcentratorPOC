using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;
using Concentrator.Entities;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class ConnectorPublicationRuleMap : EntityTypeConfiguration<ConnectorPublicationRule>
    {
        public ConnectorPublicationRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ConnectorPublicationRuleID);

            // Properties
            this.Property(t => t.AttributeValue)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ConnectorPublicationRule");
            this.Property(t => t.ConnectorPublicationRuleID).HasColumnName("ConnectorPublicationRuleID");
            this.Property(t => t.ConnectorID).HasColumnName("ConnectorID");
            this.Property(t => t.VendorID).HasColumnName("VendorID");
            this.Property(t => t.PublicationType).HasColumnName("PublicationType");
            this.Property(t => t.ProductGroupID).HasColumnName("ProductGroupID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.PublishOnlyStock).HasColumnName("PublishOnlyStock");
            this.Property(t => t.PublicationIndex).HasColumnName("PublicationIndex");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.ConnectorRelationID).HasColumnName("ConnectorRelationID");
            this.Property(t => t.FromPrice).HasColumnName("FromPrice");
            this.Property(t => t.ToPrice).HasColumnName("ToPrice");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModificationTime).HasColumnName("LastModificationTime");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.EnabledByDefault).HasColumnName("EnabledByDefault");
            this.Property(t => t.MasterGroupMappingID).HasColumnName("MasterGroupMappingID");
            this.Property(t => t.OnlyApprovedProducts).HasColumnName("OnlyApprovedProducts");
            this.Property(t => t.AttributeID).HasColumnName("AttributeID");
            this.Property(t => t.AttributeValue).HasColumnName("AttributeValue");

            // Relationships
            this.HasOptional(t => t.AssortmentStatus)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.StatusID);
            this.HasOptional(t => t.Brand)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.BrandID);
            this.HasOptional(t => t.Connector)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.ConnectorID);
            this.HasOptional(t => t.ConnectorRelation)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.ConnectorRelationID);
            this.HasOptional(t => t.MasterGroupMapping)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.MasterGroupMappingID);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.ProductID);
            this.HasOptional(t => t.ProductAttributeMetaData)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.AttributeID);
            this.HasOptional(t => t.ProductGroup)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.ProductGroupID);
            this.HasRequired(t => t.Vendor)
                .WithMany(t => t.ConnectorPublicationRules)
                .HasForeignKey(d => d.VendorID);

        }
    }
}
