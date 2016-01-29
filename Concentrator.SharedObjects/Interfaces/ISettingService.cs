using System.Collections.Generic;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ISettingService
  {
    List<SettingDto> Settings { get; }
  }
}
