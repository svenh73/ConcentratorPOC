using System.Collections.Generic;
using System.Linq;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.BusinessLayer
{
  public class SettingsService : BaseBusinessService<ISettingStoreService,ISettingBusService>, ISettingService
  {
    private List<SettingDto> _settings;

    public SettingsService(ILogService logService)
      : base(null, logService)
    {
    }

    public List<SettingDto> Settings
    {
      get
      {
        if (_settings == null)
        {
          _settings = StoreService.GetGlobalSettings().Select(p => new SettingDto
          {
            Name = p.Name,
            Value = p.Value
          }).ToList();
        }
        return _settings;
      }
    }


  }
}
