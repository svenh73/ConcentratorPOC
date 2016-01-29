using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.SharedObjects.Interfaces;
using Ninject.Modules;

namespace Concentrator.Host
{
  public class ProcessesModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IProcess>().To<Process>()
    }
  }
}
