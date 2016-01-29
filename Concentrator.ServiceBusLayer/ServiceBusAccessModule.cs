using Ninject.Modules;

namespace Concentrator.ServiceBusAccessLayer
{
  public class ServiceBusAccessModule : NinjectModule
  {
    public override void Load()
    {
      //Bind(typeof(IBaseBusService<>)).To(typeof(BaseBusService<>));
    }
  }
}
