using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class WebToPrintProject
    {
        public WebToPrintProject()
        {
            this.WebToPrintComposites = new List<WebToPrintComposite>();
            this.WebToPrintDocuments = new List<WebToPrintDocument>();
            this.WebToPrintLayouts = new List<WebToPrintLayout>();
            this.WebToPrintPages = new List<WebToPrintPage>();
            this.WebToPrintQueues = new List<WebToPrintQueue>();
        }

        public int ProjectID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<WebToPrintComposite> WebToPrintComposites { get; set; }
        public virtual ICollection<WebToPrintDocument> WebToPrintDocuments { get; set; }
        public virtual ICollection<WebToPrintLayout> WebToPrintLayouts { get; set; }
        public virtual ICollection<WebToPrintPage> WebToPrintPages { get; set; }
        public virtual ICollection<WebToPrintQueue> WebToPrintQueues { get; set; }
    }
}
