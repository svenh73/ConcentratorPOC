using System.Collections.Generic;
using System.Linq;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class SettingStoreService : BaseStoreService<SettingDto>, ISettingStoreService
  {
    
    public List<Setting> GetGlobalSettings()
    {
      return null; //return DataContext.Settings.Where(p => p.SettingValues.Any(x => x.Channel)).ToList();
    }

    public int[] GetIds()
    {
      throw new System.NotImplementedException();
    }

    public List<SettingDto> GetItems(int[] ids)
    {
      throw new System.NotImplementedException();
    }

    public int Insert(SettingDto item)
    {
      throw new System.NotImplementedException();
    }

    public bool Update(SettingDto item)
    {
      throw new System.NotImplementedException();
    }

    public bool Delete(SettingDto item)
    {
      throw new System.NotImplementedException();
    }
  }
}