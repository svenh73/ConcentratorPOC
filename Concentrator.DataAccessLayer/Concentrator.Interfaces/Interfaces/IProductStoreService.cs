
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IProductStoreService : IBaseStoreService, ICrud<ProductDto>
  {

  }
}
