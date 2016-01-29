using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class Language
    {
        public Language()
        {
            this.ConnectorLanguages = new List<ConnectorLanguage>();
            this.ConnectorRelations = new List<ConnectorRelation>();
            this.FaqProducts = new List<FaqProduct>();
            this.FaqTranslations = new List<FaqTranslation>();
            this.ProductGroupMappingDescriptions = new List<ProductGroupMappingDescription>();
            this.SeoTexts = new List<SeoText>();
            this.ProductDescriptions = new List<ProductDescription>();
            this.ProductAttributeDescriptions = new List<ProductAttributeDescription>();
            this.MasterGroupMappingCustomLabels = new List<MasterGroupMappingCustomLabel>();
            this.MasterGroupMappingDescriptions = new List<MasterGroupMappingDescription>();
            this.MasterGroupMappingLanguages = new List<MasterGroupMappingLanguage>();
            this.MasterGroupMappingMedias = new List<MasterGroupMappingMedia>();
            this.ProductAttributeValueLabels = new List<ProductAttributeValueLabel>();
            this.PaymentMethodDescriptions = new List<PaymentMethodDescription>();
            this.ProductAttributeGroupNames = new List<ProductAttributeGroupName>();
            this.ProductAttributeNames = new List<ProductAttributeName>();
            this.ProductAttributeValues = new List<ProductAttributeValue>();
            this.ProductAttributeValueGroupNames = new List<ProductAttributeValueGroupName>();
            this.ProductGroupLanguages = new List<ProductGroupLanguage>();
            this.ProductGroupMappingCustomLabels = new List<ProductGroupMappingCustomLabel>();
            this.Users = new List<User>();
        }

        public int LanguageID { get; set; }
        public string Name { get; set; }
        public string DisplayCode { get; set; }
        public virtual ICollection<ConnectorLanguage> ConnectorLanguages { get; set; }
        public virtual ICollection<ConnectorRelation> ConnectorRelations { get; set; }
        public virtual ICollection<FaqProduct> FaqProducts { get; set; }
        public virtual ICollection<FaqTranslation> FaqTranslations { get; set; }
        public virtual ICollection<ProductGroupMappingDescription> ProductGroupMappingDescriptions { get; set; }
        public virtual ICollection<SeoText> SeoTexts { get; set; }
        public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
        public virtual ICollection<ProductAttributeDescription> ProductAttributeDescriptions { get; set; }
        public virtual ICollection<MasterGroupMappingCustomLabel> MasterGroupMappingCustomLabels { get; set; }
        public virtual ICollection<MasterGroupMappingDescription> MasterGroupMappingDescriptions { get; set; }
        public virtual ICollection<MasterGroupMappingLanguage> MasterGroupMappingLanguages { get; set; }
        public virtual ICollection<MasterGroupMappingMedia> MasterGroupMappingMedias { get; set; }
        public virtual ICollection<ProductAttributeValueLabel> ProductAttributeValueLabels { get; set; }
        public virtual ICollection<PaymentMethodDescription> PaymentMethodDescriptions { get; set; }
        public virtual ICollection<ProductAttributeGroupName> ProductAttributeGroupNames { get; set; }
        public virtual ICollection<ProductAttributeName> ProductAttributeNames { get; set; }
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual ICollection<ProductAttributeValueGroupName> ProductAttributeValueGroupNames { get; set; }
        public virtual ICollection<ProductGroupLanguage> ProductGroupLanguages { get; set; }
        public virtual ICollection<ProductGroupMappingCustomLabel> ProductGroupMappingCustomLabels { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
