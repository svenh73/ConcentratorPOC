using Concentrator.Interfaces;
using Concentrator.SharedObjects.Dto;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.Processes.SendersReceivers
{
  public class AcknowledgementReceiver : BaseSenderReceiver<IAcknowledgementService>
  {
    public AcknowledgementReceiver(ICallerContext context, IAcknowledgementService service)
      : base(context, service)
    {
    }

    public override void Process()
    {
      var context = new CallerContextDto();

      var message = BusinessService.SendAcknowledgementToBus(context, Validate);
      
      throw new System.NotImplementedException();
    }

    public bool Validate(MessageEnvelopDto<AcknowledgementDto> message)
    {
      return false;
    }

    
  }
}
