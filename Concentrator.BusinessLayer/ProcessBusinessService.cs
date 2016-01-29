using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.BusinessLayer
{
  public class ProcessBusinessService : BaseBusinessService<IProcessStoreService,IProductBusService>, IProcessService
  {
    public ProcessBusinessService(ISettingService settingService, ILogService logService) : base(settingService, logService)
    {
      
    }

    public List<ProcessDto> GetProcessesForThisHost()
    {
      return new List<ProcessDto>();
    }

  }

  
}
