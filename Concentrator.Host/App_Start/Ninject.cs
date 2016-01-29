using System;
using Ninject;
using Ninject.Web.Common;
using WebActivator;

[assembly: ApplicationShutdownMethod(typeof (Concentrator.Host.App_Start.Ninject), "Stop")]

namespace Concentrator.Host.App_Start
{
    public static class Ninject
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static IKernel Kernel
        {
            get
            {
                if (Bootstrapper.Kernel == null)
                    Bootstrapper.Initialize(CreateKernel);
                return Bootstrapper.Kernel;
            }
        }


        /// <summary>
        ///     Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }


        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        ///     Load your modules or register your services here!
        /// </summary>
        private static void RegisterServices(IKernel kernel)
        {
          kernel.Load(new[] { "Concentrator.BusinessLayer.dll", "Concentrator.Processes.dll", "Concentrator.Processes.*.dll" });  
          
        }
    }
}
