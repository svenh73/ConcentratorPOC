using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class ProductGroupMapping
    {
        public ProductGroupMapping()
        {
            this.ContentProductGroups = new List<ContentProductGroup>();
            this.MagentoProductGroupSettings = new List<MagentoProductGroupSetting>();
            this.ProductGroupMappingDescriptions = new List<ProductGroupMappingDescription>();
            this.ProductGroupMapping1 = new List<ProductGroupMapping>();
            this.ProductGroupMapping11 = new List<ProductGroupMapping>();
            this.ProductGroupMappingCustomLabels = new List<ProductGroupMappingCustomLabel>();
            this.ScanDatas = new List<ScanData>();
            this.SlurpSchedules = new List<SlurpSchedule>();
        }

        public int ProductGroupMappingID { get; set; }
        public Nullable<int> ParentProductGroupMappingID { get; set; }
        public int ConnectorID { get; set; }
        public int ProductGroupID { get; set; }
        public bool FlattenHierarchy { get; set; }
        public bool FilterByParentGroup { get; set; }
        public Nullable<int> Depth { get; set; }
        public string Lineage { get; set; }
        public Nullable<int> Score { get; set; }
        public string CustomProductGroupLabel { get; set; }
        public string ProductGroupMappingLabel { get; set; }
        public string ProductGroupMappingPath { get; set; }
        public string Relation { get; set; }
        public Nullable<int> MagentoPageLayoutID { get; set; }
        public string BackendMatchingLabel { get; set; }
        public string MappingThumbnailImagePath { get; set; }
        public int MasterGroupMappingID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<ContentProductGroup> ContentProductGroups { get; set; }
        public virtual MagentoPageLayout MagentoPageLayout { get; set; }
        public virtual ICollection<MagentoProductGroupSetting> MagentoProductGroupSettings { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<ProductGroupMappingDescription> ProductGroupMappingDescriptions { get; set; }
        public virtual ICollection<ProductGroupMapping> ProductGroupMapping1 { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping2 { get; set; }
        public virtual ICollection<ProductGroupMapping> ProductGroupMapping11 { get; set; }
        public virtual ProductGroupMapping ProductGroupMapping3 { get; set; }
        public virtual ICollection<ProductGroupMappingCustomLabel> ProductGroupMappingCustomLabels { get; set; }
        public virtual ICollection<ScanData> ScanDatas { get; set; }
        public virtual ICollection<SlurpSchedule> SlurpSchedules { get; set; }
    }
}
