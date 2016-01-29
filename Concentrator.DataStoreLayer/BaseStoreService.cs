
using Concentrator.DataLayer;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class BaseStoreService<T> where T : BaseDto
  {
    public BaseStoreService(ConcentratorDataContext context = null)
    {
      ConcentratorDataContext = context ?? new ConcentratorDataContext();
    }

    protected ConcentratorDataContext ConcentratorDataContext { get; set; }
  }
}
