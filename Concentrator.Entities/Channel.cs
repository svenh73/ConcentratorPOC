using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Channel
    {
        public Channel()
        {
            this.SettingValues = new List<SettingValue>();
            this.Channel1 = new List<Channel>();
            this.ChannelProducts = new List<ChannelProduct>();
        }
      [Key]
        public int Id { get; set; }
        public int ParentChannelId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<SettingValue> SettingValues { get; set; }
        public virtual ICollection<Channel> Channel1 { get; set; }
        public virtual Channel Channel2 { get; set; }
        public virtual ICollection<ChannelProduct> ChannelProducts { get; set; }
    }
}
