using Concentrator.Interfaces;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IProductBusService : IBaseBusService, ISendReceive<ProductDto>
  {
  }
}
