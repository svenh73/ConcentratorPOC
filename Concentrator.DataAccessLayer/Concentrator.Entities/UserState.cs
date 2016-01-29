using System;
using System.Collections.Generic;

namespace Concentrator.Entities
{
    public partial class UserState
    {
        public int StateID { get; set; }
        public string EntityName { get; set; }
        public int UserID { get; set; }
        public string SavedState { get; set; }
        public virtual User User { get; set; }
    }
}
