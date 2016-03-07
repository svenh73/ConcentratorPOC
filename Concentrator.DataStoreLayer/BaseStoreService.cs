
using Concentrator.DataLayer;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class BaseStoreService<T> where T : BaseDto
  {
    public BaseStoreService(CNextContext context = null)
    {
      DataContext = context ?? new CNextContext();
    }

    protected CNextContext DataContext { get; set; }
  }
}
