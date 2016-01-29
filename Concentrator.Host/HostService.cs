using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
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
