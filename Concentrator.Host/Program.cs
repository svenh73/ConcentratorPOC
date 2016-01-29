using System.ServiceProcess;
using Concentrator.SharedObjects.Interfaces;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using Ninject.Syntax;
using NinjectAdapter;

namespace Concentrator.Host
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    static void Main()
    {
      
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[] 
            { 
                new HostService() 
            };
      ServiceBase.Run(ServicesToRun);
    }
  }
}
