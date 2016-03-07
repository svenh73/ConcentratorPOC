using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Task
    {
        public Task()
        {
            this.SettingValues = new List<SettingValue>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SettingValue> SettingValues { get; set; }
    }
}
