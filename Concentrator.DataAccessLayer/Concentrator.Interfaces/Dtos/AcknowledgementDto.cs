using Concentrator.SharedObjects.Enums;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.SharedObjects.Dtos
{
  public class AcknowledgementDto:  BaseDto, IAcknowledgement
  {
    public EntityType EntityType { get; set; }

    public int Id { get; set; }

    public AcknowledgementType Type { get; set; }

    public string Message { get; set; }
  }
}
