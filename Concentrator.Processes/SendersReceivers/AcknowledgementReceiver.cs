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

      BusinessService.SendAcknowledgementToBus(context, new AcknowledgementDto());
      
      throw new System.NotImplementedException();
    }
    
  }
}
