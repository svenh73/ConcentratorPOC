
using Concentrator.SharedObjects.Interfaces;
using Ninject.Modules;

namespace Concentrator.Host
{
  public class ProcessesModule : NinjectModule
  {
    public override void Load()
    {
      //Bind<IProcess>().To<Process>()
    }
  }
}
