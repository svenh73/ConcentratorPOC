using System.Collections.Generic;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ISettingStoreService : IBaseStoreService, ICrud<SettingDto>
  {
    List<Config> GetGlobalSettings();
  }
}
