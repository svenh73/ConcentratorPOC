using Concentrator.Interfaces;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Concentrator.BusinessLayer
{
  public class BaseBusinessService<IStore,IBus>
    where IStore : IBaseStoreService
    where IBus : IBaseBusService
  {
    public ISettingService SettingService { get; set; }
    public ILogService LogService { get; set; }


    private IStore storeservice;
    public IStore StoreService
    {
      get
      {
        if (storeservice == null)
        {
          storeservice = ServiceLocator.Current.GetInstance<IStore>();
        }
        return storeservice;
      }
    }

    private IBus busservice;
    public IBus BusService
    {
      get
      {
        if (busservice == null)
        {
          busservice = ServiceLocator.Current.GetInstance<IBus>();
        }
        return busservice;
      }
    }

    public BaseBusinessService(ISettingService settingService, ILogService logService)
    {
      SettingService = settingService;
      LogService = logService;
    }

  }
}
