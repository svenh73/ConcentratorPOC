using Concentrator.SharedObjects.Enums;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IAcknowledgement
  {
    EntityType EntityType { get; set; }
    int Id { get; set; }
    AcknowledgementType Type { get; set; }
    string Message { get; set; }
  }
}