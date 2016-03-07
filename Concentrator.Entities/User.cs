using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class User
    {
      [Key]  
      public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsActive { get; set; }
        public virtual Company Company { get; set; }
    }
}
