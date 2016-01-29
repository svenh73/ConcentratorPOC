using System.Collections.Generic;
using System.Linq;
using Concentrator.Entities;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class SettingStoreService : BaseStoreService, ISettingStoreService
  {
    
    public List<Config> GetGlobalSettings()
    {
      return ConcentratorDataContext.Configs.ToList();
    }

    public int[] GetIds()
    {
      throw new System.NotImplementedException();
    }

    List<Config> SharedObjects.Interfaces.IBaseStoreService<Config>.GetItems(int[] ids)
    {
      throw new System.NotImplementedException();
    }

    public int Insert(Config item)
    {
      throw new System.NotImplementedException();
    }

    public bool Update(Config item)
    {
      throw new System.NotImplementedException();
    }

    public bool Delete(Config item)
    {
      throw new System.NotImplementedException();
    }
  }
}