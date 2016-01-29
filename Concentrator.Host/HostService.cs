using System.ServiceProcess;
using Concentrator.SharedObjects.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Concentrator.Host
{
  public partial class HostService : ServiceBase
  {
    public HostService()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      var processservice = ServiceLocator.Current.GetInstance<IProcessService>();
      var processes = processservice.GetProcessesForThisHost();


    }

    protected override void OnStop()
    {
    }
  }
}
