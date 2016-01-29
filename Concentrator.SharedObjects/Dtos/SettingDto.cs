using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentrator.SharedObjects.Dtos
{
  public class SettingDto : BaseDto
  {
    public string Name { get; set; }

    public string Value { get; set; }
  }
}
