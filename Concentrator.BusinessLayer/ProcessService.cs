using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.Interfaces;
using Concentrator.Interfaces.Interfaces;

namespace Concentrator.BusinessLayer
{
  public class ProcessService 
  {

    public IProcessStoreService StoreService { get; set; }

    public ProcessService(IProcessStoreService processStoreService)
    {
      StoreService = processStoreService;
    }

    public List<IProcess> GetProcesses()
    {
      StoreService.GetItems()
    }
  }
}
