using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ILogService
  {
    void LogInformation(string info);
    void LogWarning(string warning);
    void LogError(string error);
  }
}
