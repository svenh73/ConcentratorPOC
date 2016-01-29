using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class MasterGroupMapping
    {
        public MasterGroupMapping()
        {
            this.ConnectorPublicationRules = new List<ConnectorPublicationRule>();
            this.ContentProductGroups = new List<ContentProductGroup>();
            this.MagentoProductGroupSettings = new List<MagentoProductGroupSetting>();
            this.MasterGroupMappingLabels = new List<MasterGroupMappingLabel>();
            this.MasterGroupMapping1 = new List<MasterGroupMapping>();
            this.MasterGroupMapping11 = new List<MasterGroupMapping>();
            this.MasterGroupMapping12 = new List<MasterGroupMapping>();
            this.MasterGroupMappingCustomLabels = new List<MasterGroupMappingCustomLabel>();
            this.MasterGroupMappingDescriptions = new List<MasterGroupMappingDescription>();
            this.MasterGroupMappingLanguages = new List<MasterGroupMappingLanguage>();
            this.MasterGroupMappingMedias = new List<MasterGroupMappingMedia>();
            this.MasterGroupMappingProducts = new List<MasterGroupMappingProduct>();
            this.MasterGroupMappingProductVendors = new List<MasterGroupMappingProductVendor>();
            this.MasterGroupMappingRelatedAttributes = new List<MasterGroupMappingRelatedAttribute>();
            this.MasterGroupMappingSettingValues = new List<MasterGroupMappingSettingValue>();
            this.ProductAttributeMetaDatas = new List<ProductAttributeMetaData>();
            this.MasterGroupMapping13 = new List<MasterGroupMapping>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
            this.ProductGroupVendors = new List<ProductGroupVendor>();
            this.Users = new List<User>();
            this.Connectors = new List<Connector>();
        }

        public int MasterGroupMappingID { get; set; }
        public Nullable<int> ParentMasterGroupMappingID { get; set; }
        public int ProductGroupID { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public Nullable<int> SourceMasterGroupMappingID { get; set; }
        public bool FlattenHierarchy { get; set; }
        public bool FilterByParentGroup { get; set; }
        public Nullable<int> ExportID { get; set; }
        public Nullable<int> SourceProductGroupMappingID { get; set; }
        public string CustomProductGroupLabel { get; set; }
        public string BackendMatchingLabel { get; set; }
        public Nullable<int> MagentoPageLayoutID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public virtual ICollection<ContentProductGroup> ContentProductGroups { get; set; }
        public virtual MagentoPageLayout MagentoPageLayout { get; set; }
        public virtual ICollection<MagentoProductGroupSetting> MagentoProductGroupSettings { get; set; }
        public virtual ICollection<MasterGroupMappingLabel> MasterGroupMappingLabels { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMapping1 { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping2 { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMapping11 { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping3 { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMapping12 { get; set; }
        public virtual MasterGroupMapping MasterGroupMapping4 { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<MasterGroupMappingCustomLabel> MasterGroupMappingCustomLabels { get; set; }
        public virtual ICollection<MasterGroupMappingDescription> MasterGroupMappingDescriptions { get; set; }
        public virtual ICollection<MasterGroupMappingLanguage> MasterGroupMappingLanguages { get; set; }
        public virtual ICollection<MasterGroupMappingMedia> MasterGroupMappingMedias { get; set; }
        public virtual ICollection<MasterGroupMappingProduct> MasterGroupMappingProducts { get; set; }
        public virtual ICollection<MasterGroupMappingProductVendor> MasterGroupMappingProductVendors { get; set; }
        public virtual ICollection<MasterGroupMappingRelatedAttribute> MasterGroupMappingRelatedAttributes { get; set; }
        public virtual ICollection<MasterGroupMappingSettingValue> MasterGroupMappingSettingValues { get; set; }
        public virtual ICollection<ProductAttributeMetaData> ProductAttributeMetaDatas { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMapping13 { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
        public virtual ICollection<ProductGroupVendor> ProductGroupVendors { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Connector> Connectors { get; set; }
    }
}
