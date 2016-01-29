using Concentrator.Interfaces;
using Concentrator.DataAccessServiceLayer;
using CoolInvest.DataAccessLayer;
using CoolInvest.Entities;

namespace CoolInvest.ServiceLayer.Services
{
  public class CoolInvestProductStoreService : ProductStoreService
  {
    public CoolInvestProductStoreService()
    {
      ConcentratorDataContext = new CoolInvestDataContext();
    }

    public int Insert(CoolInvestProduct item)
    {
      return base.Insert(item);
    }

  }
}
