using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Concentrator.Entities;
using Concentrator.DataLayer.Migrations;
using Concentrator.DataLayer.Models.Mapping;

namespace Concentrator.DataLayer
{
    public partial class ConcentratorDataContext : DbContext
    {
        static ConcentratorDataContext()
        {
          Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConcentratorDataContext, Configuration>());
        }

        public ConcentratorDataContext()
          : base("Name=DataContext")
        {
        }

        public DbSet<AdditionalOrderProduct> AdditionalOrderProducts { get; set; }
        public DbSet<AssortmentStatus> AssortmentStatus { get; set; }
        public DbSet<AttributeMatchStore> AttributeMatchStores { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandMedia> BrandMedias { get; set; }
        public DbSet<BrandVendor> BrandVendors { get; set; }
        public DbSet<ClientMappingTNT> ClientMappingTNTs { get; set; }
        public DbSet<CommunicatorMessage> CommunicatorMessages { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Connector> Connectors { get; set; }
        public DbSet<ConnectorLanguage> ConnectorLanguages { get; set; }
        public DbSet<ConnectorPaymentProvider> ConnectorPaymentProviders { get; set; }
        public DbSet<ConnectorProductStatu> ConnectorProductStatus { get; set; }
        public DbSet<ConnectorPublication> ConnectorPublications { get; set; }
        public DbSet<ConnectorPublicationRule> ConnectorPublicationRules { get; set; }
        public DbSet<ConnectorRelation> ConnectorRelations { get; set; }
        public DbSet<ConnectorRuleValue> ConnectorRuleValues { get; set; }
        public DbSet<ConnectorSchedule> ConnectorSchedules { get; set; }
        public DbSet<ConnectorSetting> ConnectorSettings { get; set; }
        public DbSet<ConnectorSystem> ConnectorSystems { get; set; }
        
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentAttribute> ContentAttributes { get; set; }
        public DbSet<ContentCalculatedPrice> ContentCalculatedPrices { get; set; }
        public DbSet<ContentFlat> ContentFlats { get; set; }
        public DbSet<ContentLedger> ContentLedgers { get; set; }
        public DbSet<ContentPrice> ContentPrices { get; set; }
        public DbSet<ContentPriceCalculation> ContentPriceCalculations { get; set; }
        public DbSet<ContentProduct> ContentProducts { get; set; }
        public DbSet<ContentProductGroup> ContentProductGroups { get; set; }
        public DbSet<ContentProductMatch> ContentProductMatches { get; set; }
        public DbSet<ContentPublicationRule> ContentPublicationRules { get; set; }
        public DbSet<ContentStock> ContentStocks { get; set; }
        public DbSet<ContentVendorSetting> ContentVendorSettings { get; set; }
        public DbSet<CrossLedgerclass> CrossLedgerclasses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DatcolLink> DatcolLinks { get; set; }
        public DbSet<EdiCommunication> EdiCommunications { get; set; }
        public DbSet<EdiFieldMapping> EdiFieldMappings { get; set; }
        public DbSet<EdiOrder> EdiOrders { get; set; }
        public DbSet<EdiOrderLedger> EdiOrderLedgers { get; set; }
        public DbSet<EdiOrderLine> EdiOrderLines { get; set; }
        public DbSet<EdiOrderListener> EdiOrderListeners { get; set; }
        public DbSet<EdiOrderPost> EdiOrderPosts { get; set; }
        public DbSet<EdiOrderResponse> EdiOrderResponses { get; set; }
        public DbSet<EdiOrderResponseLine> EdiOrderResponseLines { get; set; }
        public DbSet<EdiOrderType> EdiOrderTypes { get; set; }
        public DbSet<EdiValidate> EdiValidates { get; set; }
        public DbSet<EdiVendor> EdiVendors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<ExcludeProduct> ExcludeProducts { get; set; }
        public DbSet<ExportTemplate> ExportTemplates { get; set; }
        public DbSet<ExportTemplateColumn> ExportTemplateColumns { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqProduct> FaqProducts { get; set; }
        public DbSet<FaqTranslation> FaqTranslations { get; set; }
        public DbSet<FunctionalityRole> FunctionalityRoles { get; set; }
        public DbSet<ImageStore> ImageStores { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageCode> LanguageCodes { get; set; }
        public DbSet<MagentoPageLayout> MagentoPageLayouts { get; set; }
        public DbSet<MagentoProductGroupSetting> MagentoProductGroupSettings { get; set; }
        public DbSet<ManagementGroup> ManagementGroups { get; set; }
        public DbSet<ManagementLabel> ManagementLabels { get; set; }
        public DbSet<ManagementModule> ManagementModules { get; set; }
        public DbSet<ManagementModuleItem> ManagementModuleItems { get; set; }
        public DbSet<ManagementPage> ManagementPages { get; set; }
        public DbSet<MasterGroupMapping> MasterGroupMappings { get; set; }
        public DbSet<MasterGroupMappingCustomLabel> MasterGroupMappingCustomLabels { get; set; }
        public DbSet<MasterGroupMappingDescription> MasterGroupMappingDescriptions { get; set; }
        public DbSet<MasterGroupMappingLabel> MasterGroupMappingLabels { get; set; }
        public DbSet<MasterGroupMappingLanguage> MasterGroupMappingLanguages { get; set; }
        public DbSet<MasterGroupMappingMedia> MasterGroupMappingMedias { get; set; }
        public DbSet<MasterGroupMappingProduct> MasterGroupMappingProducts { get; set; }
        public DbSet<MasterGroupMappingProductVendor> MasterGroupMappingProductVendors { get; set; }
        public DbSet<MasterGroupMappingRelatedAttribute> MasterGroupMappingRelatedAttributes { get; set; }
        public DbSet<MasterGroupMappingSetting> MasterGroupMappingSettings { get; set; }
        public DbSet<MasterGroupMappingSettingOption> MasterGroupMappingSettingOptions { get; set; }
        public DbSet<MasterGroupMappingSettingTemplate> MasterGroupMappingSettingTemplates { get; set; }
        public DbSet<MasterGroupMappingSettingValue> MasterGroupMappingSettingValues { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<MissingContent> MissingContents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItemFullfilmentInformation> OrderItemFullfilmentInformations { get; set; }
        public DbSet<OrderLedger> OrderLedgers { get; set; }
        public DbSet<OrderLedgerStatu> OrderLedgerStatus { get; set; }
        public DbSet<orderledgertempatdatcol> orderledgertempatdatcols { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderLineAppliedDiscountRule> OrderLineAppliedDiscountRules { get; set; }
        public DbSet<OrderResponse> OrderResponses { get; set; }
        public DbSet<OrderResponseLine> OrderResponseLines { get; set; }
        public DbSet<OrderRule> OrderRules { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Outbound> Outbounds { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentMethodDescription> PaymentMethodDescriptions { get; set; }
        public DbSet<PaymentProvider> PaymentProviders { get; set; }
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Portal> Portals { get; set; }
        public DbSet<PortalNotification> PortalNotifications { get; set; }
        public DbSet<Portlet> Portlets { get; set; }
        public DbSet<PreferredConnectorVendor> PreferredConnectorVendors { get; set; }
        public DbSet<PriceCorrection> PriceCorrections { get; set; }
        public DbSet<PriceSet> PriceSets { get; set; }
        public DbSet<PriceTag> PriceTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttributeDescription> ProductAttributeDescriptions { get; set; }
        public DbSet<ProductAttributeGroupMetaData> ProductAttributeGroupMetaDatas { get; set; }
        public DbSet<ProductAttributeGroupName> ProductAttributeGroupNames { get; set; }
        public DbSet<ProductAttributeMatch> ProductAttributeMatches { get; set; }
        public DbSet<ProductAttributeMetaData> ProductAttributeMetaDatas { get; set; }
        public DbSet<ProductAttributeName> ProductAttributeNames { get; set; }
        public DbSet<ProductAttributeOption> ProductAttributeOptions { get; set; }
        public DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public DbSet<ProductAttributeValueConnectorValueGroup> ProductAttributeValueConnectorValueGroups { get; set; }
        public DbSet<ProductAttributeValueGroup> ProductAttributeValueGroups { get; set; }
        public DbSet<ProductAttributeValueGroupName> ProductAttributeValueGroupNames { get; set; }
        public DbSet<ProductAttributeValueLabel> ProductAttributeValueLabels { get; set; }
        public DbSet<ProductBarcode> ProductBarcodes { get; set; }
        public DbSet<ProductCompare> ProductCompares { get; set; }
        public DbSet<ProductCompareSource> ProductCompareSources { get; set; }
        public DbSet<ProductCompetitor> ProductCompetitors { get; set; }
        public DbSet<ProductCompetitorLedger> ProductCompetitorLedgers { get; set; }
        public DbSet<ProductCompetitorMapping> ProductCompetitorMappings { get; set; }
        public DbSet<ProductCompetitorPrice> ProductCompetitorPrices { get; set; }
        public DbSet<ProductControl> ProductControls { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductGroupConnectorVendor> ProductGroupConnectorVendors { get; set; }
        public DbSet<ProductGroupContentVendor> ProductGroupContentVendors { get; set; }
        public DbSet<ProductGroupLanguage> ProductGroupLanguages { get; set; }
        public DbSet<ProductGroupMapping> ProductGroupMappings { get; set; }
        public DbSet<ProductGroupMappingCustomLabel> ProductGroupMappingCustomLabels { get; set; }
        public DbSet<ProductGroupMappingDescription> ProductGroupMappingDescriptions { get; set; }
        public DbSet<ProductGroupPublish> ProductGroupPublishes { get; set; }
        public DbSet<ProductGroupVendor> ProductGroupVendors { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductMatch> ProductMatches { get; set; }
        public DbSet<ProductMedia> ProductMedias { get; set; }
        public DbSet<productmedia_backup> productmedia_backup { get; set; }
        public DbSet<ProductMediaTumbnail> ProductMediaTumbnails { get; set; }
        public DbSet<ProductPriceSet> ProductPriceSets { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<PushProduct> PushProducts { get; set; }
        public DbSet<RefundQueue> RefundQueues { get; set; }
        public DbSet<RefundQueueHistory> RefundQueueHistories { get; set; }
        public DbSet<RelatedProduct> RelatedProducts { get; set; }
        public DbSet<RelatedProductType> RelatedProductTypes { get; set; }
        public DbSet<RelatedProductTypeMapping> RelatedProductTypeMappings { get; set; }
        public DbSet<RelatedProductTypeMappingData> RelatedProductTypeMappingDatas { get; set; }
        public DbSet<ReviewSource> ReviewSources { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SapProductGroupMapping> SapProductGroupMappings { get; set; }
        public DbSet<SapProductGroupNumber> SapProductGroupNumbers { get; set; }
        public DbSet<ScanData> ScanDatas { get; set; }
        public DbSet<ScanProvider> ScanProviders { get; set; }
        public DbSet<SearchContent> SearchContents { get; set; }
        public DbSet<SeoText> SeoTexts { get; set; }
        public DbSet<SlurpQueue> SlurpQueues { get; set; }
        public DbSet<SlurpSchedule> SlurpSchedules { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ThumbnailGenerator> ThumbnailGenerators { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDownload> UserDownloads { get; set; }
        public DbSet<UserLanguage> UserLanguages { get; set; }
        public DbSet<UserPlugin> UserPlugins { get; set; }
        public DbSet<UserPortal> UserPortals { get; set; }
        public DbSet<UserPortalPortlet> UserPortalPortlets { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserState> UserStates { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorAccruel> VendorAccruels { get; set; }
        public DbSet<VendorAssortment> VendorAssortments { get; set; }
        public DbSet<VendorFreeGood> VendorFreeGoods { get; set; }
        public DbSet<VendorMapping> VendorMappings { get; set; }
        public DbSet<VendorPrice> VendorPrices { get; set; }
        public DbSet<VendorPriceCalculation> VendorPriceCalculations { get; set; }
        public DbSet<VendorPriceRule> VendorPriceRules { get; set; }
        public DbSet<VendorProductMatch> VendorProductMatches { get; set; }
        public DbSet<VendorProductStatus> VendorProductStatus { get; set; }
        public DbSet<VendorSetting> VendorSettings { get; set; }
        public DbSet<VendorStock> VendorStocks { get; set; }
        public DbSet<VendorStockLedger> VendorStockLedgers { get; set; }
        public DbSet<VendorStockType> VendorStockTypes { get; set; }
        public DbSet<VendorTranslation> VendorTranslations { get; set; }
        public DbSet<VendorTranslationType> VendorTranslationTypes { get; set; }
        public DbSet<WebToPrintBinding> WebToPrintBindings { get; set; }
        public DbSet<WebToPrintBindingField> WebToPrintBindingFields { get; set; }
        public DbSet<WebToPrintComposite> WebToPrintComposites { get; set; }
        public DbSet<WebToPrintDocument> WebToPrintDocuments { get; set; }
        public DbSet<WebToPrintLayout> WebToPrintLayouts { get; set; }
        public DbSet<WebToPrintPage> WebToPrintPages { get; set; }
        public DbSet<WebToPrintProject> WebToPrintProjects { get; set; }
        public DbSet<WebToPrintQueue> WebToPrintQueues { get; set; }
        public DbSet<WehkampMessage> WehkampMessages { get; set; }
        public DbSet<ZipCode> ZipCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
          
            modelBuilder.Configurations.Add(new AdditionalOrderProductMap());
            modelBuilder.Configurations.Add(new AssortmentStatusMap());
            modelBuilder.Configurations.Add(new AttributeMatchStoreMap());
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new BrandMediaMap());
            modelBuilder.Configurations.Add(new BrandVendorMap());
            modelBuilder.Configurations.Add(new ClientMappingTNTMap());
            modelBuilder.Configurations.Add(new CommunicatorMessageMap());
            modelBuilder.Configurations.Add(new ConfigMap());
            modelBuilder.Configurations.Add(new ConnectorMap());
            modelBuilder.Configurations.Add(new ConnectorLanguageMap());
            modelBuilder.Configurations.Add(new ConnectorPaymentProviderMap());
            modelBuilder.Configurations.Add(new ConnectorProductStatuMap());
            modelBuilder.Configurations.Add(new ConnectorPublicationMap());
            modelBuilder.Configurations.Add(new ConnectorPublicationRuleMap());
            modelBuilder.Configurations.Add(new ConnectorRelationMap());
            modelBuilder.Configurations.Add(new ConnectorRuleValueMap());
            modelBuilder.Configurations.Add(new ConnectorScheduleMap());
            modelBuilder.Configurations.Add(new ConnectorSettingMap());
            modelBuilder.Configurations.Add(new ConnectorSystemMap());
            
            modelBuilder.Configurations.Add(new ContentMap());
            modelBuilder.Configurations.Add(new ContentAttributeMap());
            modelBuilder.Configurations.Add(new ContentCalculatedPriceMap());
            modelBuilder.Configurations.Add(new ContentFlatMap());
            modelBuilder.Configurations.Add(new ContentLedgerMap());
            modelBuilder.Configurations.Add(new ContentPriceMap());
            modelBuilder.Configurations.Add(new ContentPriceCalculationMap());
            modelBuilder.Configurations.Add(new ContentProductMap());
            modelBuilder.Configurations.Add(new ContentProductGroupMap());
            modelBuilder.Configurations.Add(new ContentProductMatchMap());
            modelBuilder.Configurations.Add(new ContentPublicationRuleMap());
            modelBuilder.Configurations.Add(new ContentStockMap());
            modelBuilder.Configurations.Add(new ContentVendorSettingMap());
            modelBuilder.Configurations.Add(new CrossLedgerclassMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new DatcolLinkMap());
            modelBuilder.Configurations.Add(new EdiCommunicationMap());
            modelBuilder.Configurations.Add(new EdiFieldMappingMap());
            modelBuilder.Configurations.Add(new EdiOrderMap());
            modelBuilder.Configurations.Add(new EdiOrderLedgerMap());
            modelBuilder.Configurations.Add(new EdiOrderLineMap());
            modelBuilder.Configurations.Add(new EdiOrderListenerMap());
            modelBuilder.Configurations.Add(new EdiOrderPostMap());
            modelBuilder.Configurations.Add(new EdiOrderResponseMap());
            modelBuilder.Configurations.Add(new EdiOrderResponseLineMap());
            modelBuilder.Configurations.Add(new EdiOrderTypeMap());
            modelBuilder.Configurations.Add(new EdiValidateMap());
            modelBuilder.Configurations.Add(new EdiVendorMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventTypeMap());
            modelBuilder.Configurations.Add(new ExcludeProductMap());
            modelBuilder.Configurations.Add(new ExportTemplateMap());
            modelBuilder.Configurations.Add(new ExportTemplateColumnMap());
            modelBuilder.Configurations.Add(new FaqMap());
            modelBuilder.Configurations.Add(new FaqProductMap());
            modelBuilder.Configurations.Add(new FaqTranslationMap());
            modelBuilder.Configurations.Add(new FunctionalityRoleMap());
            modelBuilder.Configurations.Add(new ImageStoreMap());
            modelBuilder.Configurations.Add(new LanguageMap());
            modelBuilder.Configurations.Add(new LanguageCodeMap());
            modelBuilder.Configurations.Add(new MagentoPageLayoutMap());
            modelBuilder.Configurations.Add(new MagentoProductGroupSettingMap());
            modelBuilder.Configurations.Add(new ManagementGroupMap());
            modelBuilder.Configurations.Add(new ManagementLabelMap());
            modelBuilder.Configurations.Add(new ManagementModuleMap());
            modelBuilder.Configurations.Add(new ManagementModuleItemMap());
            modelBuilder.Configurations.Add(new ManagementPageMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingCustomLabelMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingDescriptionMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingLabelMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingLanguageMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingMediaMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingProductMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingProductVendorMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingRelatedAttributeMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingSettingMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingSettingOptionMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingSettingTemplateMap());
            modelBuilder.Configurations.Add(new MasterGroupMappingSettingValueMap());
            modelBuilder.Configurations.Add(new MediaTypeMap());
            modelBuilder.Configurations.Add(new MissingContentMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderItemFullfilmentInformationMap());
            modelBuilder.Configurations.Add(new OrderLedgerMap());
            modelBuilder.Configurations.Add(new OrderLedgerStatuMap());
            modelBuilder.Configurations.Add(new orderledgertempatdatcolMap());
            modelBuilder.Configurations.Add(new OrderLineMap());
            modelBuilder.Configurations.Add(new OrderLineAppliedDiscountRuleMap());
            modelBuilder.Configurations.Add(new OrderResponseMap());
            modelBuilder.Configurations.Add(new OrderResponseLineMap());
            modelBuilder.Configurations.Add(new OrderRuleMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new OutboundMap());
            modelBuilder.Configurations.Add(new PaymentMethodMap());
            modelBuilder.Configurations.Add(new PaymentMethodDescriptionMap());
            modelBuilder.Configurations.Add(new PaymentProviderMap());
            modelBuilder.Configurations.Add(new PluginMap());
            modelBuilder.Configurations.Add(new PortalMap());
            modelBuilder.Configurations.Add(new PortalNotificationMap());
            modelBuilder.Configurations.Add(new PortletMap());
            modelBuilder.Configurations.Add(new PreferredConnectorVendorMap());
            modelBuilder.Configurations.Add(new PriceCorrectionMap());
            modelBuilder.Configurations.Add(new PriceSetMap());
            modelBuilder.Configurations.Add(new PriceTagMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductAttributeDescriptionMap());
            modelBuilder.Configurations.Add(new ProductAttributeGroupMetaDataMap());
            modelBuilder.Configurations.Add(new ProductAttributeGroupNameMap());
            modelBuilder.Configurations.Add(new ProductAttributeMatchMap());
            modelBuilder.Configurations.Add(new ProductAttributeMetaDataMap());
            modelBuilder.Configurations.Add(new ProductAttributeNameMap());
            modelBuilder.Configurations.Add(new ProductAttributeOptionMap());
            modelBuilder.Configurations.Add(new ProductAttributeValueMap());
            modelBuilder.Configurations.Add(new ProductAttributeValueConnectorValueGroupMap());
            modelBuilder.Configurations.Add(new ProductAttributeValueGroupMap());
            modelBuilder.Configurations.Add(new ProductAttributeValueGroupNameMap());
            modelBuilder.Configurations.Add(new ProductAttributeValueLabelMap());
            modelBuilder.Configurations.Add(new ProductBarcodeMap());
            modelBuilder.Configurations.Add(new ProductCompareMap());
            modelBuilder.Configurations.Add(new ProductCompareSourceMap());
            modelBuilder.Configurations.Add(new ProductCompetitorMap());
            modelBuilder.Configurations.Add(new ProductCompetitorLedgerMap());
            modelBuilder.Configurations.Add(new ProductCompetitorMappingMap());
            modelBuilder.Configurations.Add(new ProductCompetitorPriceMap());
            modelBuilder.Configurations.Add(new ProductControlMap());
            modelBuilder.Configurations.Add(new ProductDescriptionMap());
            modelBuilder.Configurations.Add(new ProductGroupMap());
            modelBuilder.Configurations.Add(new ProductGroupConnectorVendorMap());
            modelBuilder.Configurations.Add(new ProductGroupContentVendorMap());
            modelBuilder.Configurations.Add(new ProductGroupLanguageMap());
            modelBuilder.Configurations.Add(new ProductGroupMappingMap());
            modelBuilder.Configurations.Add(new ProductGroupMappingCustomLabelMap());
            modelBuilder.Configurations.Add(new ProductGroupMappingDescriptionMap());
            modelBuilder.Configurations.Add(new ProductGroupPublishMap());
            modelBuilder.Configurations.Add(new ProductGroupVendorMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ProductMatchMap());
            modelBuilder.Configurations.Add(new ProductMediaMap());
            modelBuilder.Configurations.Add(new productmedia_backupMap());
            modelBuilder.Configurations.Add(new ProductMediaTumbnailMap());
            modelBuilder.Configurations.Add(new ProductPriceSetMap());
            modelBuilder.Configurations.Add(new ProductReviewMap());
            modelBuilder.Configurations.Add(new PushProductMap());
            modelBuilder.Configurations.Add(new RefundQueueMap());
            modelBuilder.Configurations.Add(new RefundQueueHistoryMap());
            modelBuilder.Configurations.Add(new RelatedProductMap());
            modelBuilder.Configurations.Add(new RelatedProductTypeMap());
            modelBuilder.Configurations.Add(new RelatedProductTypeMappingMap());
            modelBuilder.Configurations.Add(new RelatedProductTypeMappingDataMap());
            modelBuilder.Configurations.Add(new ReviewSourceMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SapProductGroupMappingMap());
            modelBuilder.Configurations.Add(new SapProductGroupNumberMap());
            modelBuilder.Configurations.Add(new ScanDataMap());
            modelBuilder.Configurations.Add(new ScanProviderMap());
            modelBuilder.Configurations.Add(new SearchContentMap());
            modelBuilder.Configurations.Add(new SeoTextMap());
            modelBuilder.Configurations.Add(new SlurpQueueMap());
            modelBuilder.Configurations.Add(new SlurpScheduleMap());
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new ThumbnailGeneratorMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserDownloadMap());
            modelBuilder.Configurations.Add(new UserLanguageMap());
            modelBuilder.Configurations.Add(new UserPluginMap());
            modelBuilder.Configurations.Add(new UserPortalMap());
            modelBuilder.Configurations.Add(new UserPortalPortletMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserStateMap());
            modelBuilder.Configurations.Add(new VendorMap());
            modelBuilder.Configurations.Add(new VendorAccruelMap());
            modelBuilder.Configurations.Add(new VendorAssortmentMap());
            modelBuilder.Configurations.Add(new VendorFreeGoodMap());
            modelBuilder.Configurations.Add(new VendorMappingMap());
            modelBuilder.Configurations.Add(new VendorPriceMap());
            modelBuilder.Configurations.Add(new VendorPriceCalculationMap());
            modelBuilder.Configurations.Add(new VendorPriceRuleMap());
            modelBuilder.Configurations.Add(new VendorProductMatchMap());
            modelBuilder.Configurations.Add(new VendorProductStatuMap());
            modelBuilder.Configurations.Add(new VendorSettingMap());
            modelBuilder.Configurations.Add(new VendorStockMap());
            modelBuilder.Configurations.Add(new VendorStockLedgerMap());
            modelBuilder.Configurations.Add(new VendorStockTypeMap());
            modelBuilder.Configurations.Add(new VendorTranslationMap());
            modelBuilder.Configurations.Add(new VendorTranslationTypeMap());
            modelBuilder.Configurations.Add(new WebToPrintBindingMap());
            modelBuilder.Configurations.Add(new WebToPrintBindingFieldMap());
            modelBuilder.Configurations.Add(new WebToPrintCompositeMap());
            modelBuilder.Configurations.Add(new WebToPrintDocumentMap());
            modelBuilder.Configurations.Add(new WebToPrintLayoutMap());
            modelBuilder.Configurations.Add(new WebToPrintPageMap());
            modelBuilder.Configurations.Add(new WebToPrintProjectMap());
            modelBuilder.Configurations.Add(new WebToPrintQueueMap());
            modelBuilder.Configurations.Add(new WehkampMessageMap());
            modelBuilder.Configurations.Add(new ZipCodeMap());
        }
    }
}
