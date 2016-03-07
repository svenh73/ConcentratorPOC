using System;
using System.Collections;
using System.Configuration;
using System.Linq;
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
          var customer = (ConfigurationManager.AppSettings["Customer"] ?? "Customer") + ".";

          var assemblies = AppDomain.CurrentDomain.GetAssemblies();

          var concentratorassemblies = assemblies.Where(p => p.FullName.StartsWith("Concentrator")).Select(p => p.FullName);
          var customerassemblies = assemblies.Where(p => p.FullName.StartsWith(customer)).Select(p => p.FullName);
          var assemblypartnames = customerassemblies.Where(p => p.IndexOf(".")> 0).Select(p => p.Substring(p.IndexOf(".")));
          ArrayList al = new ArrayList();

          foreach (var concentratorassembly in concentratorassemblies)
          {
            if (!assemblypartnames.Any(p => concentratorassembly.EndsWith(p)))
            {
              al.Add(concentratorassembly);
            }
          }
          al.AddRange(customerassemblies.ToList());

          kernel.Load((string[]) al.ToArray(typeof(string)));  
          
        }
    }
}
