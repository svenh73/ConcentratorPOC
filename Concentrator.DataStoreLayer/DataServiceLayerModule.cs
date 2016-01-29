using Concentrator.SharedObjects.Interfaces;
using Ninject.Modules;

namespace Concentrator.DataAccessServiceLayer
{
  public class DataServiceLayerModule : NinjectModule
  {
    public override void Load()
    {
      Bind<ISettingStoreService>().To<SettingStoreService>().InSingletonScope();
      
      Bind<IBrandStoreService>().To<BrandStoreService>();
      Bind<IProcessStoreService>().To<ProcessStoreService>();
      Bind<IProductStoreService>().To<ProductStoreService>();
    }
  }
}
