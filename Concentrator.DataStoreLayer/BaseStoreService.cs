
using Concentrator.DataLayer;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class BaseStoreService<T> where T : BaseDto
  {
    public BaseStoreService(CNxtContext context = null)
    {
      DataContext = context ?? new CNxtContext();
    }

    protected CNxtContext DataContext { get; set; }
  }
}
