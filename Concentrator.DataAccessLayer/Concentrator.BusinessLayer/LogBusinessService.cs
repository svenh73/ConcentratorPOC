using System;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.BusinessLayer
{
  public class LogBusinessService : BaseBusinessService<ILogStoreService, ILogBusService>, ILogService
  {
    public LogBusinessService(ISettingService settingService, ILogService logService)
      : base(settingService, logService)
    {
    }
    
    public void LogInformation(string info)
    {
      StoreService.Insert(new LogDto()
      {

      });
    }

    public void LogWarning(string warning)
    {
      throw new NotImplementedException();
    }

    public void LogError(string error)
    {
      throw new NotImplementedException();
    }
  }
}
