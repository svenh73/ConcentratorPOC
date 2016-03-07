using System.Data.Entity;
using Concentrator.DataAccessLayer.Mapping;

namespace Concentrator.Entities
{
  public partial class CNxtContext : DbContext
  {
    static CNxtContext()
    {
      Database.SetInitializer<CNxtContext>(null);
    }

    public CNxtContext()
      : base("Name=CNxtContext")
    {
    }

    public DbSet<Attribute> Attributes { get; set; }
    public DbSet<AttributeOption> AttributeOptions { get; set; }
    public DbSet<AttributeOptionTranslation> AttributeOptionTranslations { get; set; }
    public DbSet<AttributeTranslation> AttributeTranslations { get; set; }
    public DbSet<AttributeType> AttributeTypes { get; set; }
    public DbSet<AttributeValue> AttributeValues { get; set; }
    public DbSet<Barcode> Barcodes { get; set; }
    public DbSet<BarcodeType> BarcodeTypes { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<ChannelProduct> ChannelProducts { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Currrency> Currrencies { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<PriceType> PriceTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductGroup> ProductGroups { get; set; }
    public DbSet<ProductRelation> ProductRelations { get; set; }
    public DbSet<ProductRelationType> ProductRelationTypes { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Setting> Settings { get; set; }
    public DbSet<SettingValue> SettingValues { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<StockType> StockTypes { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<VAT> VATs { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<VendorProduct> VendorProducts { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new AttributeMap());
      modelBuilder.Configurations.Add(new AttributeOptionMap());
      modelBuilder.Configurations.Add(new AttributeOptionTranslationMap());
      modelBuilder.Configurations.Add(new AttributeTranslationMap());
      modelBuilder.Configurations.Add(new AttributeTypeMap());
      modelBuilder.Configurations.Add(new AttributeValueMap());
      modelBuilder.Configurations.Add(new BarcodeMap());
      modelBuilder.Configurations.Add(new BarcodeTypeMap());
      modelBuilder.Configurations.Add(new BrandMap());
      modelBuilder.Configurations.Add(new ChannelMap());
      modelBuilder.Configurations.Add(new ChannelProductMap());
      modelBuilder.Configurations.Add(new CompanyMap());
      modelBuilder.Configurations.Add(new CurrencyMap());
      modelBuilder.Configurations.Add(new CurrrencyMap());
      modelBuilder.Configurations.Add(new LanguageMap());
      modelBuilder.Configurations.Add(new PriceMap());
      modelBuilder.Configurations.Add(new PriceTypeMap());
      modelBuilder.Configurations.Add(new ProductMap());
      modelBuilder.Configurations.Add(new ProductGroupMap());
      modelBuilder.Configurations.Add(new ProductRelationMap());
      modelBuilder.Configurations.Add(new ProductRelationTypeMap());
      modelBuilder.Configurations.Add(new ProductTypeMap());
      modelBuilder.Configurations.Add(new SettingMap());
      modelBuilder.Configurations.Add(new SettingValueMap());
      modelBuilder.Configurations.Add(new StockMap());
      modelBuilder.Configurations.Add(new StockTypeMap());
      modelBuilder.Configurations.Add(new TaskMap());
      modelBuilder.Configurations.Add(new UserMap());
      modelBuilder.Configurations.Add(new VATMap());
      modelBuilder.Configurations.Add(new VendorMap());
      modelBuilder.Configurations.Add(new VendorProductMap());
    }
  }
}
