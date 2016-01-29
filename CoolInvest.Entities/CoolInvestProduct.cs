using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;

namespace CoolInvest.Entities
{
  [Table("Product")]
  public class CoolInvestProduct : Product
  {
    public string ExtraField { get; set; }
  }
}
