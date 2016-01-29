using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class User
    {
        public User()
        {
            this.Contents = new List<Content>();
            this.Contents1 = new List<Content>();
            this.ContentStocks = new List<ContentStock>();
            this.ContentStocks1 = new List<ContentStock>();
            this.CrossLedgerclasses = new List<CrossLedgerclass>();
            this.CrossLedgerclasses1 = new List<CrossLedgerclass>();
            this.Events = new List<Event>();
            this.Events1 = new List<Event>();
            this.ExportTemplates = new List<ExportTemplate>();
            this.Products = new List<Product>();
            this.Products1 = new List<Product>();
            this.ProductCompetitorPrices = new List<ProductCompetitorPrice>();
            this.ProductCompetitorPrices1 = new List<ProductCompetitorPrice>();
            this.ProductDescriptions = new List<ProductDescription>();
            this.ProductDescriptions1 = new List<ProductDescription>();
            this.RelatedProducts = new List<RelatedProduct>();
            this.RelatedProducts1 = new List<RelatedProduct>();
            this.UserDownloads = new List<UserDownload>();
            this.UserPlugins = new List<UserPlugin>();
            this.UserPortals = new List<UserPortal>();
            this.UserRoles = new List<UserRole>();
            this.UserStates = new List<UserState>();
            this.WebToPrintProjects = new List<WebToPrintProject>();
            this.MasterGroupMappings = new List<MasterGroupMapping>();
        }

        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreationTime { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public int LanguageID { get; set; }
        public Nullable<int> ConnectorID { get; set; }
        public string Logo { get; set; }
        public Nullable<int> Timeout { get; set; }
        public string Email { get; set; }
        public int OrganizationID { get; set; }
        public virtual Connector Connector { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Content> Contents1 { get; set; }
        public virtual ICollection<ContentStock> ContentStocks { get; set; }
        public virtual ICollection<ContentStock> ContentStocks1 { get; set; }
        public virtual ICollection<CrossLedgerclass> CrossLedgerclasses { get; set; }
        public virtual ICollection<CrossLedgerclass> CrossLedgerclasses1 { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Event> Events1 { get; set; }
        public virtual ICollection<ExportTemplate> ExportTemplates { get; set; }
        public virtual Language Language { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Product> Products1 { get; set; }
        public virtual ICollection<ProductCompetitorPrice> ProductCompetitorPrices { get; set; }
        public virtual ICollection<ProductCompetitorPrice> ProductCompetitorPrices1 { get; set; }
        public virtual ICollection<ProductDescription> ProductDescriptions { get; set; }
        public virtual ICollection<ProductDescription> ProductDescriptions1 { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProducts { get; set; }
        public virtual ICollection<RelatedProduct> RelatedProducts1 { get; set; }
        public virtual ICollection<UserDownload> UserDownloads { get; set; }
        public virtual ICollection<UserPlugin> UserPlugins { get; set; }
        public virtual ICollection<UserPortal> UserPortals { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserState> UserStates { get; set; }
        public virtual ICollection<WebToPrintProject> WebToPrintProjects { get; set; }
        public virtual ICollection<MasterGroupMapping> MasterGroupMappings { get; set; }
    }
}
