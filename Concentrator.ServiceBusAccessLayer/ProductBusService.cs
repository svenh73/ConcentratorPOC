
using System;
using Concentrator.Interfaces.Interfaces;
using Concentrator.SharedObjects;

namespace Concentrator.ServiceBusAccessLayer
{
  public class ProductBusService : BaseBusService<ProductDto>, IProductBusService
  {

    public void Send(ICallerContext context, ProductDto product)
    {
      Send(context, product);
    }

    public MessageEnvelop<ProductDto> Receive(ICallerContext context, Func<MessageEnvelop<ProductDto>, bool> funcValidate)
    {
      throw new NotImplementedException();
    }

    public ProductBusService(string connectstring, string path) : base(connectstring, path)
    {
    }
  }
}
