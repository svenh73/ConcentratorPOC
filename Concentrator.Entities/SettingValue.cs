using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class SettingValue
    {
        public SettingValue()
        {
            //this.Vendors = new List<Vendor>();
        }
      [Key]
        public int Id { get; set; }
        public Nullable<int> ChannelId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public int SettingId { get; set; }
        public string Environment { get; set; }
        public string Value { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual Task Task { get; set; }
        //public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
