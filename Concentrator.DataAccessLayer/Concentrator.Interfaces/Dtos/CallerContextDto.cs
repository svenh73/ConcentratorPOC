using Concentrator.SharedObjects.Enums;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.SharedObjects.Dtos
{
  public class CallerContextDto : BaseDto, ICallerContext
  {
    public string DataSource { get; set; }
    public string UserName { get; set; }
    public int? VendorId { get; set; }
    public int? ConnectorId { get; set; }
    public int UserId { get; set; }
    public Rights Rights { get; set; }
  }
}
