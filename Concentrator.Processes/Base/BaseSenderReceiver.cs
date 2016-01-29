
using Concentrator.SharedObjects.Interfaces;
using Microsoft.ServiceBus.Messaging;

namespace Concentrator.Processes
{
  public class BaseSenderReceiver<T> where T : IBaseBusinessService
  {
    protected readonly ICallerContext Context;
    protected readonly T BusinessService;

    public BaseSenderReceiver(ICallerContext context, T service)
    {
      BusinessService = service;
      Context = context;
    }

    public virtual void Process()
    {
      throw new System.NotImplementedException();
    }
  }
}
