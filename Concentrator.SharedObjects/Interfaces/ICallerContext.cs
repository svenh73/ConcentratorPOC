
using Concentrator.SharedObjects.Enums;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ICallerContext
  {
    string DataSource { get; set; }
    string UserName { get; set; }
    int? VendorId { get; set; }
    int? ConnectorId { get; set; }
    int UserId { get; set; }
    Rights Rights { get; set; }
  }
}
