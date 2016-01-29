
using System;
using Concentrator.SharedObjects;
using Concentrator.SharedObjects.Dto;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.ServiceBusAccessLayer
{
  public class ProductBusService : BaseBusService<ProductDto>, IProductBusService
  {

    public void Send(ICallerContext context, ProductDto product)
    {
      Send(context, product);
    }

    public MessageEnvelopDto<ProductDto> Receive(ICallerContext context, Func<MessageEnvelopDto<ProductDto>, bool> funcValidate)
    {
      throw new NotImplementedException();
    }

    public ProductBusService(string connectstring, string path) : base(connectstring, path)
    {
    }
  }
}
