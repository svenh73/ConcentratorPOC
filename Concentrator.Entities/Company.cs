using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Concentrator.Entities
{
    public partial class Company
    {
        public Company()
        {
            this.Users = new List<User>();
            this.Vendors = new List<Vendor>();
        }
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
