using System.Collections.Generic;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.BusinessLayer
{
  public class AcknowledgementBusinessService : BaseBusinessService<IAcknowledgementStoreService, IAcknowledgementBusService>, IAcknowledgementService
  {
    public AcknowledgementBusinessService(ISettingService settingService, ILogService logService)
      : base(settingService, logService)
    {
    }

    public void SendAcknowledgementToBus(ICallerContext context, AcknowledgementDto acknowledgement)
    {
      BusService.Send(context, acknowledgement);
    }
  }
}
