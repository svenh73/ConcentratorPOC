using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class VendorSetting
    {
        public int VendorID { get; set; }
        public string SettingKey { get; set; }
        public string Value { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
